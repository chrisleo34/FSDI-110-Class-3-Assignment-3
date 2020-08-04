function fetchData() {
  $.ajax({
    url: "/catalog/getCatalog",
    type: "GET",
    data: JSON.stringify(property),
    contentType: "application/json",
    success: function (data) {
      console.log("Server responded with", data);

      // travel the array
      //get each property
      // display the property in html
    },
    error: function (details) {
      console.log("Error", details);
    },
  });
}

function init() {
  console.log("Catalog page");

  fetchData();
}

window.onload = init;

function myFunction() {
  var x = document.getElementById("myTopnav");
  if (x.className === "topnav") {
    x.className += " responsive";
  } else {
    x.className = "topnav";
  }
}
