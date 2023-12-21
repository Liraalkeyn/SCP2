let sales_button_next_one = document.getElementById("GalleryRightArrow");
    
sales_button_next_one.onclick = () => {
document.getElementById("container").scrollLeft += 620;
};

let sales_button_next_two = document.getElementById("GalleryRightArrow");

sales_button_next_two.onclick = () => {
document.getElementById("container").scrollLeft += 620;
};

let sales_button_next_three = document.getElementById("GalleryLeftArrow");

sales_button_next_three.onclick = () => {
document.getElementById("container").scrollLeft -= 620;
};
