function focusInput(id) {
    document.getElementById(id).focus();
}

function scroll(index) {
    var grid = document.getElementsByClassName("e-grid")[0].blazor__instance;
    var rowHeight = grid.getRows()[index].scrollHeight; grid.getContent().scrollTop = rowHeight * index;                //do the calculations to set the scrollTop value for grid content 
}

function SetPageTitle(title) {
    document.title = title;
}

