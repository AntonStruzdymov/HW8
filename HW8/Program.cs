using HW8Library;
BluePrinter blue = new BluePrinter();
GreenPrinter green = new GreenPrinter();
Room thisRoom = new Room();
thisRoom.CurrentPrinter(blue);
thisRoom.MakeThisLazyPrinterWork("Тестовая строка");
thisRoom.CurrentPrinter(green);
thisRoom.MakeThisLazyPrinterWork("Тестовая строка");
