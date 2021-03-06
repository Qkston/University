Лабораторна робота №2
Тема: Двовимірні масиви.
Мета: Ознайомитися з методами обробки двовимірних масивів.
Хід роботи: Виконати завдання за варіантом. Введення, виведення масиву, обробку реалізувати у вигляді окремих методів. Створити блок-схему до завдання 4.

Завдання 1. Дано цілочисельну прямокутну матрицю (а не зубчастий масив). Скласти програми розв’язання таких задач (у варіантах 1–4, 12–15 результатом є єдине число, у варіантах 5–11 — фрази вигляду «в …-му рядку/стовпчику результат дорівнює …», причому ці фрази слід виводити для деяких з рядків/стовпчиків, залежно від умови варіанту та вмісту матриці):
1.	 Визначити кількість рядків, які не містять нулів.
2.	 Визначити кількість стовпців, які не містять нулів.
3.	 Визначити кількість стовпців, які містять хоча б один нуль.
4.	 Визначити кількість рядків, які містять хоча б один нуль.
5.	 Визначити добуток елементів у кожному рядку, що не містить нуля.
6.	 Визначити добуток елементів у кожному стовпці, що не містить нуля.
7.	 Визначити суму елементів у кожному рядку, що не містить від’ємних чисел.
8.	 Визначити суму елементів у кожному стовпці, що не містить від’ємних чисел.
9.	 Визначити середнє арифметичне елементів у кожному рядку, який містить хоча б один нуль.
10.	 Визначити середнє арифметичне елементів у кожному стовпці, який містить хоча б один нуль.
11.	 Визначити суму елементів у кожному рядку, який містить хоча б одне від’ємне число.
12.	 Визначити суму елементів у кожному стовпці, який містить хоча б одне від’ємне число.
13.	 Знайти номер першого з рядків, що не містить від’ємних чисел (врахувати, що таких може й не бути).
14.	 Знайти номер останнього з рядків, що не містить від’ємних чисел (врахувати, що таких може й не бути).
15.	 Знайти номер останнього зі стовпців, що не містить нуля (врахувати, що таких може й не бути).



Завдання 2.
Дано цілочисельну прямокутну матрицю (а не зубчастий масив).
1.	Записати на місце від'ємних елементів матриці нулі, а на місце додатних — одиниці (нулі залишити нулями).
2.	Поміняти місцями перший з максимальних і перший з мінімальних елементів матриці; «перший» рахується згідно стандартного порядку «рядок за рядком згори донизу, всередині рядків зліва направо».
3.	Знайти в кожному рядку перший з максимальних і перший з мінімальних елементів і поставити їх на першому (технічно 0-му) і останньому місцях рядка. Зверніть увагу, що випадки «перший є мінімальним» та/або «останній є єдиним максимальним» можуть потребувати окремого розгляду.
4.	Знайти в кожному рядку перший з максимальних елементів і поміняти місцями з елементом головної діагоналі. 
5.	Знайти в кожній колонці перший з мінімальних елементів і поміняти місцями з першим (технічно 0-им) елементом колонки.
6.	Транспонувати матрицю, лишаючи її в тому самому масиві; вважати, що матриця гарантовано квадратна.
7.	Поміняти місцями перший з максимальних і перший (технічно 0-ий) елементи в кожному рядку матриці.
8.	Дана матриця, не обов’язково квадратна. Записати в інший масив результат її транспонування (в тому числі, слід створити цей інший масив, потрібних розмірів).
9.	Знайти рядок з максимальною кількістю нулів і поміняти його місцями з першим (технічно 0-им) рядком. Якщо є різні рядки з однаковою максимальною кількістю нулів, обмінювати перший з них.
10.	Поміняти місцями елементи головної і побічної діагоналей; вважати, що матриця гарантовано квадратна.
11.	Знайти на головній і побічній діагоналях максимальні елементи і поміняти їх місцями; вважати, що матриця гарантовано квадратна; якщо діагональ містить кілька однакових максимальних елементів, вибирати перший (найвищий) з них.
12.	Поміняти місцями відповідні елементи першого рядка і головної діагоналі; вважати, що матриця гарантовано квадратна.
13.	Знайти рядок з максимальним елементом матриці і поміняти його (рядок) місцями з побічною діагоналлю; вважати, що матриця гарантовано квадратна; якщо матриця містить кілька максимальних елементів, вибирати перший з них, згідно стандартного порядку «рядок за рядком згори донизу, всередині рядків зліва направо».
14.	Якщо хоча б один з максимальних елементів матриці лежить на головній діагоналі, то перенести його (елемент) на побічну діагональ симетрично відносно вертикалі; якщо таких елементів кілька, то перенести їх усі.
15.	Поміняти місцями відповідні елементи першої (технічно 0-ої) колонки і побічної діагоналі.
16.	Поміняти місцями перший з максимальних і перший з мінімальних елементів кожного рядка.

Завдання 3.
Дано одновимірний цілочисельний масив. Виконати перетворення, яке може змінювати кількість елементів у ньому. Для зміни кількості елементів рекомендується використовувати один з двох способів:
(a)	Викликати Array.Resize(arr). 
(b)	«Вручну» створити новий масив і переписати, наприклад, то лише потрібну частину старого, або ще якимсь чином змінений старий.
В принципі можливий і якийсь інший спосіб, але обов’язково, щоб і до початку всіх дій, і після завершення всіх дій значення властивості .Length відповідало кількості реально використаних елементів (протягом роботи, поки якраз відбуваються зміни, це, як правило, буде не так). Настійливо рекомендується уникати багатократних викликів Array.Resize(), як-то не викликати для вставки кожного окремого елементу, а один раз змінити розмір так, щоб можна було вставити зразу всі.

1.	Знищити перший парний елемент (якщо такий взагалі є)
2.	Знищити перший від’ємний елемент (якщо такий взагалі є)
3.	Знищити елемент із заданим ключем (значенням); якщо таких нема, масив незмінний, якщо багато — вилучається лише перший
4.	Знищити елемент із заданим номером
5.	Знищити N елементів, починаючи з номеру К
6.	Знищити всі парні елементи (тобто, з парними значеннями)
7.	Знищити всі елементи з парними індексами
8.	Знищити всі непарні елементи (тобто, з непарними значеннями)
9.	Знищити всі елементи з непарними індексами
10.	Додати елемент в початок масиву
11.	Додати елемент в кінець масиву
12.	Додати К елементів в початок масиву (тобто, вставити їх, «зсунувши хвіст»)
13.	Додати К елементів в кінець масиву
14.	Додати К елементів, починаючи з номеру N (тобто, вставити їх, «зсунувши хвіст»)
15.	Додати після кожного від’ємного елемента його модуль
16.	Додати після кожного парного елемента елемент із значенням 0
17.	Додати елемент з номером К (тобто, вставити його, «зсунувши хвіст»)


Завдання 4.
Дано цілочисельний масив, прямокутний за фактичним наповненням, але зубчастий за технічним способом зберігання. Виконати вказане перетворення, якнайактивніше використовуючи можливість переприсвоєнь посилань (і, таким чином, перестановки/зміщення рядків без фактичних перестановок/зміщень елементів всередині тих рядків). Забезпечити також всі вимоги попереднього пункту щодо Array.Resize() або альтернативного способу, який забезпечує, щоб і до початку всіх дій, і після завершення всіх дій значення властивості .Length відповідало кількості реально використаних елементів (протягом роботи, поки якраз відбуваються зміни, це, як правило, буде не так).

1.	Додати рядок із заданим номером
2.	Додати рядок в початок матриці
3.	Додати К рядків в кінець матриці
4.	Додати К рядків в початок матриці
5.	Знищити рядок з номером К
6.	Знищити рядки, починаючи з рядка К1 і до рядка К2
7.	Знищити всі парні рядки (тобто, рядки з парними номерами)
8.	Знищити всі рядки, в яких є хоча б один нульовий елемент 
9.	Знищити рядок, в якому знаходиться найбільший елемент матриці (якщо у різних місцях є кілька елементів з однаковим максимальним значенням, то лише перший з них)
10.	Додати по одному рядку після кожного парного рядка матриці (тобто, кожного рядка, що у початковій матриці мав парний номер)
11.	Додати К рядків, починаючи з рядка з номером N
12.	Додати рядок після рядка, що містить найбільший елемент (якщо у різних місцях є кілька елементів з однаковим максимальним значенням, то брати перший з них)
13.	Додати рядок перед рядком, що містить найбільший елемент (якщо у різних місцях є кілька елементів з однаковим максимальним значенням, то брати останній з них)
14.	Додати рядок перед рядком, що містить найменший елемент (якщо у різних місцях є кілька елементів з однаковим мінімальним значенням, то брати перший з них)
15.	Додати рядок після рядка, що містить найменший елемент (якщо у різних місцях є кілька елементів з однаковим мінімальним значенням, то брати останній з них) 
