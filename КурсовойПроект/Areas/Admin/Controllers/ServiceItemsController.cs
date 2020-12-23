using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using КурсовойПроект.Domain;
using КурсовойПроект.Domain.Entities;
using КурсовойПроект.Service;

namespace КурсовойПроект.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment; //для сохранения картинок
        public ServiceItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        // по идентификатору ищем услугу в базе данных, и если услуга не найдена, то создаём новый объект
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new ServiceItem() : dataManager.ServiceItems.GetServiceItemById(id);
            //если же айдишник найден, то мы выбираем из базы данных
            return View(entity);


        }
        [HttpPost]
        public IActionResult Edit(ServiceItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {   //если титульная картинка не равна нулю
                if (titleImageFile != null)
                {   //то для названия картинки в самой модели берём название из этого файла
                    model.TitleImagePath = titleImageFile.FileName;
	                    //используя файлстрим кидаем файл в wwwroot
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    { // копируем
                        titleImageFile.CopyTo(stream);
                    }
                }
                //создаём услугу и перенаправляем пользователя на главную в админке
                dataManager.ServiceItems.SaveServiceItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        // для удаления услуг
        public IActionResult Delete(Guid id)
        {
            dataManager.ServiceItems.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}