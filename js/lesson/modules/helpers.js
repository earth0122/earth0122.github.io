function displayName() {
  alert("My Name is Kevin");
}

var $title = function (title) {
  console.log("");
  var len = Math.floor((60 - title.length) / 2);
  title =
    title.length > 0
      ? `${"=".repeat(len)}${title}${"=".repeat(len)}`
      : "=".repeat(60);
  console.log(title);
};

var $ex = function (title) {
  console.log("");
  var len = Math.floor((50 - title.length) / 2);
  title =
    title.length > 0
      ? `${".".repeat(len)}${title}${".".repeat(len)}`
      : "=".repeat(60);
  console.log(title);
};

function $g(selector) {
  //nodelist⾄少包含⼀個node - Element object
  //如果沒有符合的，則會是⼀個empty NodeList
  let nodelist = document.querySelectorAll(selector);

  if (nodelist.length == 0) {
    return null;
  }

  return nodelist.length == 1 ? nodelist[0] : nodelist;
}

export { $g };

function $c(element) {
  return document.createElement(element);
}

function $ct(element, text) {
  let el = document.createElement(element);

  if (text !== null && text !== undefined && text.length > 0) {
    el.innerText = text;
  }

  return el;
}

function $log(value) {
  console.log(value);
}

function $random(min, max) {
  return Math.floor(Math.random() * (max - min) + min);
}

export { displayName as showName, $title, $ex, $log, $random, $c, $ct };
