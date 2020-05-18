using Doors.Data.Interfaces;
using Doors.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doors.Data.Mocks
{
    public class MockDoorRepository : IDoorRepository
    { 
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Door> Doors
        {
            get
            {
                return new List<Door>
                    {
                        new Door {
                            Name = "МетаЛюкс М90",
                            Price = 7.95M, 
                            ShortDescription = "Модель МетаЛюкс М90",
                            LongDescription = "Размеры: 860, 960*2050 мм Толщина: полотно - 65 мм, короб - 90 мм Краска: покрытие Искра, цвет черный Толщина металла полотна: 1 мм Толщина металла короба: 1.5 мм Отделка снаружи: металл, покрытие «Искра», цвет черный Отделка внутри: панель МДФ 6 мм, цвет «Венге» Нижний замок: «Border Standart» (цилиндровый)",
                            Category = _categoryRepository.Categories.First(),
                            ImageUrl = "http://imgh.us/beerL_2.jpg",
                            InStock = true,
                            IsPreferredDoor = true,
                            ImageThumbnailUrl = "http://imgh.us/beerS_1.jpeg"
                        },
                        new Door {
                            Name = "МетаЛюкс М200",
                            Price = 12.95M, 
                            ShortDescription = "Модель МетаЛюкс М200",
                            LongDescription = "Размеры: 860, 960*2050 мм Толщина: полотно - 65 мм, короб - 90 мм Краска: покрытие Искра, цвет черный Толщина металла полотна: 1 мм Толщина металла короба: 1.5 мм Отделка снаружи: металл с декоративным тиснением, покрытие «Искра», цвет черный Отделка внутри: панель МДФ 6 мм, цвет «Венге» Верхний замок: «Border Standart» (сувальдный) Нижний замок: «Border Standart» (цилиндровый)",
                            Category =  _categoryRepository.Categories.First(),
                            ImageUrl = "http://imgh.us/rumCokeL.jpg",
                            InStock = true,
                            IsPreferredDoor = false,
                            ImageThumbnailUrl = "http://imgh.us/rumAndCokeS.jpg"
                        },
                        new Door {
                            Name = "Амати 00 Орех темный",
                            Price = 12.95M, 
                            ShortDescription = "Модель Амати 00 Орех темный",
                            LongDescription = "Каркас полотна: сосновый брус. Покрытие: Экошпон. Коробка: 31*75*2070 мм (телескопическая с уплотнителем). Наличник: 70/8*23*2200, 90/8*23*2200 мм (телескопический).",
                            Category =  _categoryRepository.Categories.First(),
                            ImageUrl = "http://imgh.us/tequilaL.jpg",
                            InStock = true,
                            IsPreferredDoor = false,
                            ImageThumbnailUrl = "http://imgh.us/tequilaS.jpg"
                        },
                        new Door
                        {
                            Name = "Амати 00 Эшвайт",
                            Price = 12.95M,
                            ShortDescription = "Модель Амати 00 Орех темный",
                            LongDescription = "Каркас полотна: сосновый брус. Покрытие: Экошпон. Коробка: 31*75*2070 мм (телескопическая с уплотнителем). Наличник: 70/8*23*2200, 90/8*23*2200 мм (телескопический).",
                            Category = _categoryRepository.Categories.Last(),
                            ImageUrl = "http://imgh.us/juiceL.jpg",
                            InStock = true,
                            IsPreferredDoor = false,
                            ImageThumbnailUrl = "http://imgh.us/juiceS.jpg"
                        }
                    };
            }
        }
        public IEnumerable<Door> PreferredDoors { get;  }

            public Door GetDoorById(int doorId)
            {
                throw new NotImplementedException();
            }
    }
}
