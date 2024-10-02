

// changes styles based on screen width
function responsive() {
    // width of screen
    var width = window.innerWidth 
    const smallImage1 = document.getElementById('smallImage1');
    const smallImage2= document.getElementById('smallImage2');
    const smallImage3 = document.getElementById('smallImage3');
    const icons = document.getElementById('iconGrid');
    var footer = document.getElementById('footer');
    // for elements with width greater than 950 pixels 
    if (width > 950) {
        //stops hiding small images
        smallImage3.classList.remove('hide');
        smallImage2.classList.remove('hide');
        // changes icon grid to be horizontal
        icons.className = "grid-x grid-margin-x align-center";

        // changes size of small image cells 
        smallImage1.className = "cell small-3";
        smallImage2.className = "cell small-3"
        smallImage3.className = "cell small-3";
        // changes image for footer
        footer.src = 'Assets/Footer.png';
    }
    else if ((width < 950) && (width > 450)) {
        // hides a small image 
        smallImage3.classList.add('hide');
        // changes icon grid to be horixontal
        icons.className = "grid-x grid-margin-x align-center";
        // stops hideing a small image 
        smallImage2.classList.remove('hide');
        // increases size of small image container 
        smallImage1.className = "cell small-6";
        smallImage2.className = "cell small-6";
        footer.src = 'Assets/Tabletfooter.png';


    }
    else if (width < 450) {
        smallImage2.classList.add('hide');
        icons.className = "grid-y grid-margin-y align-center";
        smallImage1.className = "cell small-9";
        footer.src = 'Assets/phoneFooter.png';

    }
}
function changeNavbar() {
    var width = window.innerWidth
    // navbar buttons
    const button1 = document.getElementById('button1');
    const button2 = document.getElementById('button2');
    const button3 = document.getElementById('button3');
    const button4 = document.getElementById('button4');
    const button5 = document.getElementById('button5');
    const button6 = document.getElementById('button6');
    const button7 = document.getElementById('button7');
    //hides buttons if screen width is less than 1000 pixles
    if (width < 1000) {
        button1.classList.add('hide');
        button2.classList.add('hide');
        button3.classList.add('hide');
        button4.classList.add('hide');
        button5.classList.add('hide');
        button6.classList.add('hide');
        button7.classList.add('hide');
    }
    // shows buttons if screen is more than 1000 pixels
    else {
        button1.classList.remove('hide');
        button2.classList.remove('hide');
        button3.classList.remove('hide');
        button4.classList.remove('hide');
        button5.classList.remove('hide');
        button6.classList.remove('hide');
        button7.classList.remove('hide');
    }
}




// screen resize event calls previous functions
window.addEventListener('resize', responsive);
window.addEventListener('resize', changeNavbar);