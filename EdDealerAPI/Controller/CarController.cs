using EdDealerAPI.Data;
using EdDealerAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdDealerAPI.Controller
{
    [ApiController]
    public class CarController : ControllerBase
    {
        public readonly Context context;

        public CarController(Context context)
        {
            this.context = context;
        }

    }
}
