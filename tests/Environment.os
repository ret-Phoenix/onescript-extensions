#Использовать asserts
#Использовать extensions

Функция ПолучитьСписокТестов(Тестирование) Экспорт

	СписокТестов = Новый Массив;
	СписокТестов.Добавить("Тест_Должен_ВернутьСистемныйКаталог");
	СписокТестов.Добавить("Тест_Должен_ВернутьЭто64Бита");
	СписокТестов.Добавить("Тест_Должен_ВернутьКоличествоПроцессоров");
	СписокТестов.Добавить("Тест_Должен_ВернутьРазмерСистемнойСтраницы");
	СписокТестов.Добавить("Тест_Должен_ВернутьВремяРаботыСМоментаЗагрузки");
	СписокТестов.Добавить("Тест_Должен_ВернутьАргументыКоманднойСтроки");
	СписокТестов.Добавить("Тест_Должен_ВернутьИменаЛогическихДисков");
	СписокТестов.Добавить("Тест_Должен_ВернутьСпециальнаяПапка");
	СписокТестов.Добавить("Тест_Должен_ВернутьКаталогСпециальнойПапки");
	
	Возврат СписокТестов;

КонецФункции

Процедура Тест_Должен_ВернутьСистемныйКаталог() Экспорт
	Окружение = Новый Окружение();
	Ожидаем.Что(Окружение.СистемныйКаталог).Заполнено();
КонецПроцедуры

Процедура Тест_Должен_ВернутьЭто64Бита() Экспорт
	Окружение = Новый Окружение();
	Ожидаем.Что(Окружение.Это64БитнаяОперационнаяСистема).ЭтоИстина();
КонецПроцедуры

Процедура Тест_Должен_ВернутьКоличествоПроцессоров() Экспорт
	Окружение = Новый Окружение();
	Ожидаем.Что(Окружение.КоличествоПроцессоров).Больше(1);
КонецПроцедуры

Процедура Тест_Должен_ВернутьРазмерСистемнойСтраницы() Экспорт
	Ожидаем.Что(Новый Окружение().РазмерСистемнойСтраницы).Больше(1);
КонецПроцедуры

Процедура Тест_Должен_ВернутьВремяРаботыСМоментаЗагрузки() Экспорт
	Ожидаем.Что(Новый Окружение().ВремяРаботыСМоментаЗагрузки).Больше(1);
КонецПроцедуры

Процедура Тест_Должен_ВернутьАргументыКоманднойСтроки() Экспорт
	
	Окружение = Новый Окружение();
	Аргументы = Окружение.АргументыКоманднойСтроки;
	
	Ожидаем.Что(Аргументы[0]).Равно("oscript.exe");
	Ожидаем.Что(Аргументы[2]).Содержит("-run");
	Ожидаем.Что(Аргументы.Количество()).Равно(4);

КонецПроцедуры

Процедура Тест_Должен_ВернутьИменаЛогическихДисков() Экспорт
	Ожидаем.Что(Новый Окружение().ИменаЛогическихДисков.Количество()).Больше(0);
КонецПроцедуры

Процедура Тест_Должен_ВернутьСпециальнаяПапка() Экспорт
	Ожидаем.Что(Новый Окружение().СпециальнаяПапка).Существует();
КонецПроцедуры

Процедура Тест_Должен_ВернутьКаталогСпециальнойПапки() Экспорт
	Окружение = Новый Окружение();
	СпециальнаяПапка = Окружение.СпециальнаяПапка;
	Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.МоиДокументы)).ЭтоНе().Равно("");
	Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.РабочийСтол)).ЭтоНе().Равно("");
	Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.Принтеры)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.МойКомпьютер)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.Программы)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.РепозиторийДокументов)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.Избранное)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.Автозагрузка)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.НедавниеДокументы)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.Отправить)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.СтартовоеМеню)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.МояМузыка)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.КаталогРабочийСтол)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.Шаблоны)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.ДанныеПриложений)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.ЛокальныйКаталогДанныхПриложений)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.ИнтернетКеш)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.Куки)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.История)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.ОбщийКаталогДанныхПриложения)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.Система)).ЭтоНе().Равно("");
	// Ожидаем.Что(Окружение.ПолучитьПутьПапки(СпециальнаяПапка.ПрограммныеФайлы)).ЭтоНе().Равно("");
КонецПроцедуры
