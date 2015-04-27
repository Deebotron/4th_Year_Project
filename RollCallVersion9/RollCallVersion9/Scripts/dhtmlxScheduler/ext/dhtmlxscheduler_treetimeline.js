/*
@license
dhtmlxScheduler.Net v.3.3.0 Professional Evaluation

This software is covered by DHTMLX Evaluation License. Contact sales@dhtmlx.com to get Commercial or Enterprise license. Usage without proper license is prohibited.

(c) Dinamenta, UAB.
*/
Scheduler.plugin(function(e){e.attachEvent("onTimelineCreated",function(t){"tree"==t.render&&(t.y_unit_original=t.y_unit,t.y_unit=e._getArrayToDisplay(t.y_unit_original),e.attachEvent("onOptionsLoadStart",function(){t.y_unit=e._getArrayToDisplay(t.y_unit_original)}),e.form_blocks[t.name]={render:function(e){var t="<div class='dhx_section_timeline' style='overflow: hidden; height: "+e.height+"px'></div>";return t},set_value:function(t,a,n,i){var r=e._getArrayForSelect(e.matrix[i.type].y_unit_original,i.type);

t.innerHTML="";var d=document.createElement("select");t.appendChild(d);var o=t.getElementsByTagName("select")[0];!o._dhx_onchange&&i.onchange&&(o.onchange=i.onchange,o._dhx_onchange=!0);for(var l=0;l<r.length;l++){var s=document.createElement("option");s.value=r[l].key,s.value==n[e.matrix[i.type].y_property]&&(s.selected=!0),s.innerHTML=r[l].label,o.appendChild(s)}},get_value:function(e,t,a){return e.firstChild.value},focus:function(e){}})}),e.attachEvent("onBeforeSectionRender",function(t,a,n){var i={};

if("tree"==t){var r,d,o,l,s,_;a.children?(r=n.folder_dy||n.dy,n.folder_dy&&!n.section_autoheight&&(o="height:"+n.folder_dy+"px;"),d="dhx_row_folder",l="dhx_matrix_scell folder",s="<div class='dhx_scell_expand'>"+(a.open?"-":"+")+"</div>",_=n.folder_events_available?"dhx_data_table folder_events":"dhx_data_table folder"):(r=n.dy,d="dhx_row_item",l="dhx_matrix_scell item"+(e.templates[n.name+"_scaley_class"](a.key,a.label,a)?" "+e.templates[n.name+"_scaley_class"](a.key,a.label,a):""),s="",_="dhx_data_table");

var c="<div class='dhx_scell_level"+a.level+"'>"+s+"<div class='dhx_scell_name'>"+(e.templates[n.name+"_scale_label"](a.key,a.label,a)||a.label)+"</div></div>";i={height:r,style_height:o,tr_className:d,td_className:l,td_content:c,table_className:_}}return i});var t;e.attachEvent("onBeforeEventChanged",function(a,n,i){if(e._isRender("tree"))for(var r=e._get_event_sections?e._get_event_sections(a):[a[e.matrix[e._mode].y_property]],d=0;d<r.length;d++){var o=e.getSection(r[d]);if(o&&"undefined"!=typeof o.children&&!e.matrix[e._mode].folder_events_available)return i||(a[e.matrix[e._mode].y_property]=t),
!1}return!0}),e.attachEvent("onBeforeDrag",function(a,n,i){if(e._isRender("tree")){var r,d=e._locate_cell_timeline(i);if(d&&(r=e.matrix[e._mode].y_unit[d.y].key,"undefined"!=typeof e.matrix[e._mode].y_unit[d.y].children&&!e.matrix[e._mode].folder_events_available))return!1;var o=e.getEvent(a),l=e.matrix[e._mode].y_property;t=o&&o[l]?o[l]:r}return!0}),e._getArrayToDisplay=function(t){var a=[],n=function(t,i){for(var r=i||0,d=0;d<t.length;d++)t[d].level=r,"undefined"!=typeof t[d].children&&"undefined"==typeof t[d].key&&(t[d].key=e.uid()),
a.push(t[d]),t[d].open&&t[d].children&&n(t[d].children,r+1)};return n(t),a},e._getArrayForSelect=function(t,a){var n=[],i=function(t){for(var r=0;r<t.length;r++)e.matrix[a].folder_events_available?n.push(t[r]):"undefined"==typeof t[r].children&&n.push(t[r]),t[r].children&&i(t[r].children,a)};return i(t),n},e._toggleFolderDisplay=function(t,a,n){var i,r=function(e,t,a,n){for(var d=0;d<t.length&&(t[d].key!=e&&!n||!t[d].children||(t[d].open="undefined"!=typeof a?a:!t[d].open,i=!0,n||!i));d++)t[d].children&&r(e,t[d].children,a,n);

},d=e.getSection(t);"undefined"!=typeof a||n||(a=!d.open),e.callEvent("onBeforeFolderToggle",[d,a,n])&&(r(t,e.matrix[e._mode].y_unit_original,a,n),e.matrix[e._mode].y_unit=e._getArrayToDisplay(e.matrix[e._mode].y_unit_original),e.callEvent("onOptionsLoad",[]),e.callEvent("onAfterFolderToggle",[d,a,n]))},e.attachEvent("onCellClick",function(t,a,n,i,r){e._isRender("tree")&&(e.matrix[e._mode].folder_events_available||"undefined"!=typeof e.matrix[e._mode].y_unit[a]&&"undefined"!=typeof e.matrix[e._mode].y_unit[a].children&&e._toggleFolderDisplay(e.matrix[e._mode].y_unit[a].key));

}),e.attachEvent("onYScaleClick",function(t,a,n){e._isRender("tree")&&"undefined"!=typeof a.children&&e._toggleFolderDisplay(a.key)}),e.getSection=function(t){if(e._isRender("tree")){var a,n=function(e,t){for(var i=0;i<t.length;i++)t[i].key==e&&(a=t[i]),t[i].children&&n(e,t[i].children)};return n(t,e.matrix[e._mode].y_unit_original),a||null}},e.deleteSection=function(t){if(e._isRender("tree")){var a=!1,n=function(e,t){for(var i=0;i<t.length&&(t[i].key==e&&(t.splice(i,1),a=!0),!a);i++)t[i].children&&n(e,t[i].children);

};return n(t,e.matrix[e._mode].y_unit_original),e.matrix[e._mode].y_unit=e._getArrayToDisplay(e.matrix[e._mode].y_unit_original),e.callEvent("onOptionsLoad",[]),a}},e.deleteAllSections=function(){e._isRender("tree")&&(e.matrix[e._mode].y_unit_original=[],e.matrix[e._mode].y_unit=e._getArrayToDisplay(e.matrix[e._mode].y_unit_original),e.callEvent("onOptionsLoad",[]))},e.addSection=function(t,a){if(e._isRender("tree")){var n=!1,i=function(e,t,r){if(a)for(var d=0;d<r.length&&(r[d].key==t&&"undefined"!=typeof r[d].children&&(r[d].children.push(e),
n=!0),!n);d++)r[d].children&&i(e,t,r[d].children);else r.push(e),n=!0};return i(t,a,e.matrix[e._mode].y_unit_original),e.matrix[e._mode].y_unit=e._getArrayToDisplay(e.matrix[e._mode].y_unit_original),e.callEvent("onOptionsLoad",[]),n}},e.openAllSections=function(){e._isRender("tree")&&e._toggleFolderDisplay(1,!0,!0)},e.closeAllSections=function(){e._isRender("tree")&&e._toggleFolderDisplay(1,!1,!0)},e.openSection=function(t){e._isRender("tree")&&e._toggleFolderDisplay(t,!0)},e.closeSection=function(t){
e._isRender("tree")&&e._toggleFolderDisplay(t,!1)}});