using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Zelda.Models;

namespace Zelda.ActionFilters
{
    public class ValidationActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var MenuItems = context.RouteData.Values.OfType<IMenuItem>();
            var OrderData = context.RouteData.Values.OfType<IOrdersData>();
            if (MenuItems.Any(p => p is null))
                context.Result = new BadRequestObjectResult("Menu item null");
            if (OrderData.Any(p => p is null))
                context.Result = new BadRequestObjectResult("Order related data is null");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            return;
        }
    }
}
