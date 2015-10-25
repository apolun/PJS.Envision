jQuery(document).ready(function () {
    // set minimum page height
    jQuery('#page-content').css('min-height', '500px');

    // change down arrow to side arrow on sub menus
    jQuery('ul.sub-menu .fa-angle-down').removeClass('fa-angle-down').addClass('fa-angle-right');

    // pagination
    jQuery('#pager_currentpage').parent('li').addClass('ui--box ui--gradient ui--gradient-grey ui--pagination-current-item');
    jQuery('.pager_link').parent('li').addClass('ui--box ui--gradient ui--gradient-grey');

    // widget title
    jQuery('#sidebars .ui--widget-title').addClass('sidebar-widget-title');
    jQuery('footer .ui--widget-title').addClass('footer-widget-title');
});