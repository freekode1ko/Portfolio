-- phpMyAdmin SQL Dump
-- version 4.4.15.7
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1:3306
-- Время создания: Авг 21 2016 г., 19:55
-- Версия сервера: 5.5.50
-- Версия PHP: 5.3.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `Spray`
--

-- --------------------------------------------------------

--
-- Структура таблицы `categories`
--

CREATE TABLE IF NOT EXISTS `categories` (
  `id` int(10) unsigned NOT NULL,
  `title` varchar(255) NOT NULL,
  `parent` int(10) unsigned NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `categories`
--

INSERT INTO `categories` (`id`, `title`, `parent`) VALUES
(1, 'Цветной винил', 3),
(2, 'Бесцветный винил', 3),
(3, 'Весь винил', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `pages`
--

CREATE TABLE IF NOT EXISTS `pages` (
  `page_id` tinyint(3) unsigned NOT NULL,
  `title` varchar(255) NOT NULL,
  `alias` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `keywords` varchar(255) NOT NULL,
  `text` text NOT NULL,
  `position` tinyint(3) unsigned NOT NULL DEFAULT '0'
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `pages`
--

INSERT INTO `pages` (`page_id`, `title`, `alias`, `description`, `keywords`, `text`, `position`) VALUES
(1, 'Главная', 'index', 'Desc main', 'key main', 'Main texp', 1),
(2, 'О компании', 'about', 'Desc about us', 'key about', 'Text about us', 3),
(3, 'Заказать', 'order', 'order', 'order', '<html><body> \r\n \r\n<form action= "/post.php" method= "POST"> \r\n \r\n<p>Ваше имя: </p><p> <input type= "text" name= "name"> </p> \r\n \r\n<p>Ваш Е-Mail: </p><p> <input type= "text" name= "email"></p> \r\n \r\n<p>Номер или название товара: </p><p> <textarea rows= "10" cols= "45" name= "message"></textarea></p> \r\n \r\n<input type= "submit" value= "Оформить заказ"> \r\n<p>\r\n</p>\r\n<br>\r\n</body></html> ', 2);

-- --------------------------------------------------------

--
-- Структура таблицы `products`
--

CREATE TABLE IF NOT EXISTS `products` (
  `id` int(10) unsigned NOT NULL,
  `title` varchar(255) NOT NULL,
  `alias` varchar(255) NOT NULL,
  `parent` int(10) unsigned NOT NULL,
  `content` text NOT NULL,
  `image` varchar(255) NOT NULL DEFAULT 'empty_thumb.jpg',
  `price` float NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `products`
--

INSERT INTO `products` (`id`, `title`, `alias`, `parent`, `content`, `image`, `price`) VALUES
(10, 'Tiger', 'tiger', 1, '', 'product.jpg', 112),
(11, 'Tiger2', 'tiger2', 2, '', 'product.jpg', 121),
(12, 'Lion', 'lion', 1, '', 'product.jpg', 211),
(13, 'Lion2', 'lion2', 2, '', 'product.jpg', 212),
(14, 'DickHead', 'dickhead', 1, '', 'product.jpg', 221),
(15, 'Boost', 'boost', 1, 'Интерьерные наклейки могут иметь вид абстракций, узоров, надписей, животных, птиц, растений, зданий (или отдельных их частей), техники, разнообразных предметов, людей (в том числе, знаменитостей). Они бывают монохромными, двухцветными или разноцветными.\r\n\r\nДля изготовления наклеек используется технология плоттерная резка пленки. В режущий плоттер или каттер вставляется виниловая пленка, потом, в зависимости от толщины пленки, устанавливается давление нажима ножа. Для резки подготавливается файл в векторном формате eps или cdr. После того как каттер прорежет нужный рисунок, лишние части пленки необходимо зачистить. после этого, уже почти готовая, наклейка закатывается в монтажную пленку. Получается "сэндвич" из трех пленок - 1. Монтажная пленка (нужна для переноса наклейки на поверхность) 2. Сама наклейка и 3. Подложка - Пленка, чаще всего на бумажной основе, на которой находится наклейка до переноса на стену.\r\n\r\nРазмеры таких наклеек сильно разнятся: они могут быть как совсем небольшими, так и огромными.\r\n\r\nВиниловые наклейки широко используются по всему миру для декорирования жилых помещений или отдельных элементов интерьера, офисов, магазинов, для украшения автомашин, а также в детском творчестве — например, при обучении дошкольников алфавиту.\r\n\r\nК несомненным достоинствам виниловых интерьерных стикеров, кроме их высокой декоративности, относятся: простота использования, водостойкость, универсальность (можно приклеить практически к любой гладкой поверхности: металлической, стеклянной, деревянной, керамической, каменной, бумажной, пластиковой), безопасность для человека, долговечность, стойкость к солнечному ультрафиолету и механическим воздействиям. Многие виды виниловых рисунков можно использовать несколько раз, переклеивая с места на место, без вреда для поверхности.\r\n\r\nОклейка предметов, в первую очередь, автомобилей, рисунками из виниловой плёнки обозначается термином «винилография».', 'product.jpg', 100),
(16, 'break', 'break', 1, '', 'product.jpg', 200),
(17, 'charged', 'charged', 1, '', 'product.jpg', 100),
(18, 'ChekEngine', 'chekengine', 2, '', 'product.jpg', 200),
(19, 'Driftins Donuts', 'driftins-donuts', 2, '', 'product.jpg', 200),
(20, 'Dubway', 'dubway', 2, '', 'product.jpg', 111),
(21, 'need head', 'need-head', 1, '', 'product.jpg', 500),
(22, 'haters gona hate', 'haters-gona-hate', 2, '', 'product.jpg', 500),
(23, 'no rice', 'no-rice', 1, '', 'product.jpg', 400),
(24, 'FWD is sucks', 'fwd-is-sucks', 2, '', 'product.jpg', 500);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `pages`
--
ALTER TABLE `pages`
  ADD PRIMARY KEY (`page_id`),
  ADD UNIQUE KEY `alias` (`alias`);

--
-- Индексы таблицы `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(10) unsigned NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT для таблицы `pages`
--
ALTER TABLE `pages`
  MODIFY `page_id` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT для таблицы `products`
--
ALTER TABLE `products`
  MODIFY `id` int(10) unsigned NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=25;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
