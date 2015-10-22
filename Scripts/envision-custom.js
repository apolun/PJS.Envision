jQuery(document).ready(function () {
    // set minimum page height
    jQuery('#page-content').css('min-height', '500px');

    // change down arrow to side arrow on sub menus
    jQuery('ul.sub-menu .fa-angle-down').removeClass('fa-angle-down').addClass('fa-angle-right');
});