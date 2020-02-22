using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Manatee.Trello;
using System.Collections.Generic;

namespace HelperFunctions
{
    public static class GetIngredientsListFromTrello
    {
        [FunctionName("GetIngredientsListFromTrello")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Request to gather all ingredients.");

            var recipeIngredients = await GetDataAsync();

            return new OkObjectResult(JsonConvert.SerializeObject(recipeIngredients));
        }

        private static async Task<object> GetDataAsync()
        {
            TrelloAuthorization.Default.AppKey = "660a224291cd8cd592b315947a05c402";
            TrelloAuthorization.Default.UserToken = "5688f1600c6e7f3e30113e478363fb3d1b3f3c1a6cb1e1ce1bab31b5e24b6adf";

            var factory = new TrelloFactory();
            const string weeklyEatsBoardId = "GgB8CiSU";
            var board = factory.Board(weeklyEatsBoardId);
            await board.Lists.Refresh();

            var recipeIngredients = new List<object>();
            var thisWeekLists = board.Lists.Where(list => list.Name.StartsWith("This Week")).ToList();
            foreach (var list in thisWeekLists)
            {
                foreach (var card in list.Cards)
                {
                    await card.Comments.Refresh();
                    var ingredientComment = card.Comments.SingleOrDefault(comment => comment.Data.Text.StartsWith("Ingredients"));
                    if (ingredientComment != null)
                    {
                        var ingredientsString = ingredientComment.Data.Text.Substring("Ingredients\n".Length);
                        var ingredients = ingredientsString.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                        recipeIngredients.Add(
                            new
                            {
                                RecipeName = card.Name,
                                Ingredients = ingredients,
                            });
                    }
                }
            }
            return recipeIngredients;
        }
    }
}
