// Write your Javascript code.
$(document).ready(function () {

});

$('.card-text.name').click(function () {
  var cardName = $('.card-text.name');
  var testIndex = $(this).index('.card-text.name');
  var clickedIndex = $(cardName).eq(testIndex);

  clickedIndex.siblings().slideToggle();
});
