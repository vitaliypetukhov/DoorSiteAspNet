using Doors.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace Doors.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Doors.Any())
            {
                context.AddRange
                (
                    new Door
                    {
                        Name = "Модель 01 Беленый Дуб",
                        Price = 7.95M,
                        ShortDescription = "МЕЖКОМНАТНАЯ ДВЕРЬ ЛАМИНИРОВАННАЯ СТАНДАРТ 01 БЕЛЁНЫЙ ДУБ",
                        LongDescription = "Каркас полотна: сосновый брус. Наполнение: сотовое. Плита: МДФ. Покрытие: С (ламинированные) Н (ламинатиновое). Коробка: 26*70*2070 мм. Наличник: 70*10*2150.",
                        Category = Categories["InteriorDoors"],
                        ImageUrl = "http://imgh.us/C1_beldybL.jpg",
                        InStock = true,
                        IsPreferredDoor = true,
                        ImageThumbnailUrl = "http://imgh.us/C1_beldybS.jpeg"
                    },
                    new Door
                    {
                        Name = "Амати 1 Дуб Беленый",
                        Price = 12.95M,
                        ShortDescription = "МЕЖКОМНАТНАЯ ДВЕРЬ ЭКОШПОН АМАТИ 1 ДУБ БЕЛЁНЫЙ",
                        LongDescription = "Каркас полотна: сосновый брус. Покрытие: Экошпон. Коробка: 31*75*2070 мм (телескопическая с уплотнителем). Наличник: 70/8*23*2200, 90/8*23*2200 мм (телескопический).",
                        Category = Categories["InteriorDoors"],
                        ImageUrl = "http://imgh.us/Amati_1_Dyb_BelenijL.jpg",
                        InStock = true,
                        IsPreferredDoor = false,
                        ImageThumbnailUrl = "http://imgh.us/Amati_1_Dyb_BelenijS.jpg"
                    },
                    new Door
                    {
                        Name = "Амати 1 Дуб Шале-Графит",
                        Price = 12.95M,
                        ShortDescription = "МЕЖКОМНАТНАЯ ДВЕРЬ ЭКОШПОН АМАТИ 1 ДУБ ШАЛЕ-ГРАФИТ",
                        LongDescription = "Каркас полотна: сосновый брус. Покрытие: Экошпон. Коробка: 31*75*2070 мм (телескопическая с уплотнителем). Наличник: 70/8*23*2200, 90/8*23*2200 мм (телескопический).",
                        Category = Categories["InteriorDoors"],
                        ImageUrl = "http://imgh.us/Amati_1_Dyb_ShaleL.jpg",
                        InStock = true,
                        IsPreferredDoor = false,
                        ImageThumbnailUrl = "http://imgh.us/Amati_1_Dyb_ShaleS.jpeg"
                    },
                    
                    new Door
                    {
                        Name = "Модель 02 Венге",
                        Price = 16.75M,
                        ShortDescription = "МЕЖКОМНАТНАЯ ДВЕРЬ ИСКУССТВЕННЫЙ ШПОН НОВЫЙ СТАНДАРТ 02Ф ВЕНГЕ",
                        LongDescription = "Каркас полотна: сосновый брус. Наполнение: сотовое. Плита: МДФ. Покрытие: С (ламинированные) Н (ламинатиновое). Коробка: 26*70*2070 мм. Наличник: 70*10*2150.",
                        Category = Categories["InteriorDoors"],
                        ImageUrl = "http://imgh.us/H2f_vengeL.jpg",
                        InStock = true,
                        IsPreferredDoor = false,
                        ImageThumbnailUrl = "http://imgh.us/H2f_vengeS.jpeg"
                    },
                    new Door
                    {
                        Name = "Модель 01 Итальянский Орех",
                        Price = 14.95M,
                        ShortDescription = "МЕЖКОМНАТНАЯ ДВЕРЬ ЛАМИНИРОВАННАЯ СТАНДАРТ 01 ИТАЛЬЯНСКИЙ ОРЕХ",
                        LongDescription = "Каркас полотна: сосновый брус. Наполнение: сотовое. Плита: МДФ. Покрытие: С (ламинированные) Н (ламинатиновое). Коробка: 26*70*2070 мм. Наличник: 70*10*2150.",
                        Category = Categories["InteriorDoors"],
                        ImageUrl = "http://imgh.us/C1_italL.jpg",
                        InStock = true,
                        IsPreferredDoor = false,
                        ImageThumbnailUrl = "http://imgh.us/C1_italS.jpeg"
                    },
                    new Door
                    {
                        Name = "Эмаль 1 Белая",
                        Price = 16.95M,
                        ShortDescription = "МЕЖКОМНАТНАЯ ДВЕРЬ ЭМАЛИРОВАННАЯ ЭМАЛЬ ПГ-1 БЕЛЫЙ",
                        LongDescription = "Каркас полотна: сосновый брус. Плита: ХДФ 6 мм. Покрытие: Эмаль. Коробка: 31*75*2070 мм (телескопическая с уплотнителем). Наличник: 70/8*23*2200, 90/8*23*2200 мм (телескопический).",
                        Category = Categories["InteriorDoors"],
                        ImageUrl = "http://imgh.us/Emal_PG1_BelijL.jpg",
                        InStock = true,
                        IsPreferredDoor = false,
                        ImageThumbnailUrl = "http://imgh.us/Emal_PG1_BelijS.jpeg"
                    },
                    //нет в наличии
                    new Door
                    {
                        Name = "Палермо массив сосны",
                        Price = 18.95M,
                        ShortDescription = "МЕЖКОМНАТНАЯ ДВЕРЬ МАССИВ СОСНЫ ПАЛЕРМО ПВДО СЛОНОВАЯ КОСТЬ (ОКА)",
                        LongDescription = "Возможные цвета: «Венге», «Античный орех», «Слоновая кость», «Грей», «Махагон», «Белый», «Скай», «Крем».",
                        Category = Categories["InteriorDoors"],
                        ImageUrl = "http://imgh.us/Palermo_Slon_KostL.jpg",
                        InStock = false,
                        IsPreferredDoor = false,
                        ImageThumbnailUrl = "http://imgh.us/Palermo_Slon_KostS.jpeg"
                    },
                    new Door
                    {
                        Name = "Эмаль 2 Белая",
                        Price = 18.95M,
                        ShortDescription = "МЕЖКОМНАТНАЯ ДВЕРЬ ЭМАЛИРОВАННАЯ ЭМАЛЬ ПГ-2 БЕЛЫЙ",
                        LongDescription = "Каркас полотна: сосновый брус. Плита: ХДФ 6 мм. Покрытие: Эмаль. Коробка: 31*75*2070 мм (телескопическая с уплотнителем). Наличник: 70/8*23*2200, 90/8*23*2200 мм (телескопический).",
                        Category = Categories["InteriorDoors"],
                        ImageUrl = "http://imgh.us/Emal_PG2_BelijL.jpg",
                        InStock = true,
                        IsPreferredDoor = false,
                        ImageThumbnailUrl = "http://imgh.us/Emal_PG2_BelijS.jpeg"
                    },
                    new Door
                    {
                        Name = "Классика Орех Итальянский",
                        Price = 12.95M,
                        ShortDescription = "МЕЖКОМНАТНАЯ ДВЕРЬ ЛАМИНИРОВАННАЯ КЛАССИК ПГ ОРЕХ ИТАЛЬЯНСКИЙ",
                        LongDescription = "Каркас полотна: сосновый брус. Наполнение: сотовое. Плита: МДФ. Покрытие: ламинированные. Коробка (притвор 35 мм): 26*70*2070 мм. Наличник: 70*10*2150.",
                        Category = Categories["InteriorDoors"],
                        ImageUrl = "http://imgh.us/Klassika_PG_italL.jpg",
                        InStock = false,
                        IsPreferredDoor = false,
                        ImageThumbnailUrl = "http://imgh.us/Klassika_PG_italS.jpeg"
                    },
                    // входные двери
                    new Door
                    {
                        Name = "МетаЛюкс М90",
                        Price = 12.95M,
                        ShortDescription = "ВХОДНАЯ ДВЕРЬ МЕТАЛЮКС М90",
                        LongDescription = "Размеры: 860, 960*2050 мм Толщина: полотно - 65 мм, короб - 90 мм Краска: покрытие Искра, цвет черный Толщина металла полотна: 1 мм Толщина металла короба: 1.5 мм Отделка снаружи: металл, покрытие «Искра», цвет черный Отделка внутри: панель МДФ 6 мм, цвет «Венге» Нижний замок: «Border Standart» (цилиндровый)",
                        Category = Categories["InputDoors"],
                        ImageUrl = "http://imgh.us/M90_VneshnL.jpg",
                        InStock = true,
                        IsPreferredDoor = true,
                        ImageThumbnailUrl = "http://imgh.us/M90_VneshnS.jpg"
                    },
                    new Door
                    {
                        Name = "МетаЛюкс М100",
                        Price = 19.95M,
                        ShortDescription = "ВХОДНАЯ ДВЕРЬ МЕТАЛЮКС М100",
                        LongDescription = "Размеры: 860, 960*2050 мм Толщина: полотно - 65 мм, короб - 90 мм Краска: покрытие Искра, цвет черный Толщина металла полотна: 1 мм Толщина металла короба: 1.5 мм Отделка снаружи: металл с декоративным тиснением, покрытие «Искра», цвет черный Отделка внутри: панель МДФ 6 мм, цвет «Венге» Верхний замок: «Border Standart» (сувальдный) Нижний замок: «Border Standart» (цилиндровый)",
                        Category = Categories["InputDoors"],
                        ImageUrl = "http://imgh.us/M100_VnytrL.jpg",
                        InStock = true,
                        IsPreferredDoor = false,
                        ImageThumbnailUrl = "http://imgh.us/M100_VnytrS_1.jpg"
                    },
                    new Door
                    {
                        Name = "МетаЛюкс М102",
                        Price = 20.95M,
                        ShortDescription = "ВХОДНАЯ ДВЕРЬ МЕТАЛЮКС М102",
                        LongDescription = "Размеры: 860, 960*2050 мм Толщина: полотно - 65 мм, короб - 90 мм Краска: покрытие Искра, цвет черный Толщина металла полотна: 1 мм Толщина металла короба: 1.5 мм Отделка снаружи: металл с декоративным тиснением, покрытие «Искра», цвет черный Отделка внутри: панель МДФ 6 мм, цвет «Беленый дуб» Верхний замок: «Border Standart» (сувальдный) Нижний замок: «Border Standart» (цилиндровый)",
                        Category = Categories["InputDoors"],
                        ImageUrl = "http://imgh.us/M102_VnytrL.jpg",
                        InStock = true,
                        IsPreferredDoor = true,
                        ImageThumbnailUrl = "http://imgh.us/M102_VnytrS.jpg"
                    },
                    new Door
                    {
                        Name = "МетаЛюкс М101",
                        Price = 18.95M,
                        ShortDescription = "ВХОДНАЯ ДВЕРЬ МЕТАЛЮКС М101",
                        LongDescription = "Размеры: 860, 960*2050 мм Толщина: полотно - 65 мм, короб - 90 мм Краска: покрытие Искра, цвет черный Толщина металла полотна: 1 мм Толщина металла короба: 1.5 мм Отделка снаружи: металл с декоративным тиснением, покрытие «Искра», цвет черный Отделка внутри: панель МДФ 6 мм, цвет «Вишня» Верхний замок: «Border Standart» (сувальдный) Нижний замок: «Border Standart» (цилиндровый)",
                        Category = Categories["InputDoors"],
                        ImageUrl = "http://imgh.us/M101_VnytrL.jpg",
                        InStock = true,
                        IsPreferredDoor = false,
                        ImageThumbnailUrl = "http://imgh.us/M101_VnytrS.jpg"
                    },
                    new Door
                    {
                        Name = "МетаЛюкс М201",
                        Price = 22.95M,
                        ShortDescription = "ВХОДНАЯ ДВЕРЬ МЕТАЛЮКС М201",
                        LongDescription = "Размеры: 860, 960*2050 мм Толщина: полотно - 65 мм, короб - 90 мм Краска: покрытие Искра, цвет черный Толщина металла полотна: 1 мм Толщина металла короба: 1.5 мм Отделка снаружи: металл с декоративным тиснением, покрытие «Искра», цвет черный Отделка внутри: панель МДФ 6 мм, цвет «Дуб молочный» Верхний замок: «Border Standart» (сувальдный) Нижний замок: «Border Standart» (цилиндровый)",
                        Category = Categories["InputDoors"],
                        ImageUrl = "http://imgh.us/M201_VnytrL.jpg",
                        InStock = true,
                        IsPreferredDoor = false,
                        ImageThumbnailUrl = "http://imgh.us/M201_VnytrS.jpg"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "InputDoors", Description="All input doors" },
                        new Category { CategoryName = "InteriorDoors", Description="All interior doors" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
