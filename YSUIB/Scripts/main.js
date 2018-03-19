$(document).ready(function () {
    addNavActiveClass()
    var slideIndex = 1;
    showSlides(slideIndex);

    function plusSlides(n) {
      showSlides(slideIndex += n);
    }

    function currentSlide(n) {
      showSlides(slideIndex = n);
    }

    function showSlides(n) {
      var i;
      var slides = document.getElementsByClassName("mySlides");
      var dots = document.getElementsByClassName("dot");
      if (n > slides.length) {slideIndex = 1}
      if (n < 1) {slideIndex = slides.length}
      for (i = 0; i < slides.length; i++) {
          slides[i].style.display = "none";
      }
      for (i = 0; i < dots.length; i++) {
          dots[i].className = dots[i].className.replace(" active", "");
      }
      slides[slideIndex-1].style.display = "block";
      dots[slideIndex-1].className += " active";
    }
    var slideIndex = 0;
    showSlides();

    function showSlides() {
        var i;
        var slides = document.getElementsByClassName("mySlides");
        for (i = 0; i < slides.length; i++) {
            slides[i].style.display = "none";
        }
        slideIndex++;
        if (slideIndex > slides.length) {slideIndex = 1}
        slides[slideIndex-1].style.display = "block";
        setTimeout(showSlides, 1500); // Change image every 2 seconds
    }

    function ValidateEmail(mail)
        {
         if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(myForm.emailAddr.value))
          {
            return (true)
          }
            alert("You have entered an invalid email address!")
            return (false)
    }

    function count(element) {
        var fps = 10;
        var duration = 2; // seconds

        var current = parseInt(element.html(), 10);
        var data = element.data('count');
        current = current + Math.ceil(data/(fps*duration));
        
        if(current >= data) {
            element.html(data);
        } else {
            element.html(current);
            setTimeout(function () {
                count(element);
            }, 1000/fps);
        }

    }

    jQuery(".div-count").each(function () {
        jQuery(this).data('count', parseInt(jQuery(this).html(), 10));
        jQuery(this).html('0');
        var upThis = this;
        setTimeout(function () { count(jQuery(upThis)); }, 1000);
        

    });
   
});


function addNavActiveClass() {
    var url     = window.location.href;
    var origin  = window.location.origin;
    var href    = url.slice(origin.length,url.length);

    $('ul.nav a').filter(function () {
        return this.href == url;
    }).parent().addClass('active');
}