"use strict";
(self["webpackChunkdemo"] = self["webpackChunkdemo"] || []).push([["src_app_home_home_module_ts"],{

/***/ 5988:
/*!****************************************!*\
  !*** ./src/app/core/services/index.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "TrackService": () => (/* reexport safe */ _track_service__WEBPACK_IMPORTED_MODULE_0__.TrackService)
/* harmony export */ });
/* harmony import */ var _track_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./track.service */ 2653);



/***/ }),

/***/ 2653:
/*!************************************************!*\
  !*** ./src/app/core/services/track.service.ts ***!
  \************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "TrackService": () => (/* binding */ TrackService)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 4001);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common/http */ 6781);


class TrackService {
    constructor(http) {
        this.http = http;
    }
    getTracks(page) {
        let params = {
            "limit": page.limit,
            "offset": page.offset
        };
        return this.http.get(`https://localhost:5001/api/tracks`, { params: params });
    }
}
TrackService.ɵfac = function TrackService_Factory(t) { return new (t || TrackService)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵinject"](_angular_common_http__WEBPACK_IMPORTED_MODULE_1__.HttpClient)); };
TrackService.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineInjectable"]({ token: TrackService, factory: TrackService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ 3949:
/*!*********************************************!*\
  !*** ./src/app/home/home-routing.module.ts ***!
  \*********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "HomeRoutingModule": () => (/* binding */ HomeRoutingModule)
/* harmony export */ });
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ 3252);
/* harmony import */ var _home_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./home.component */ 4018);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 4001);




const routes = [{ path: '', component: _home_component__WEBPACK_IMPORTED_MODULE_0__.HomeComponent }];
class HomeRoutingModule {
}
HomeRoutingModule.ɵfac = function HomeRoutingModule_Factory(t) { return new (t || HomeRoutingModule)(); };
HomeRoutingModule.ɵmod = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineNgModule"]({ type: HomeRoutingModule });
HomeRoutingModule.ɵinj = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjector"]({ imports: [[_angular_router__WEBPACK_IMPORTED_MODULE_2__.RouterModule.forChild(routes)], _angular_router__WEBPACK_IMPORTED_MODULE_2__.RouterModule] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵsetNgModuleScope"](HomeRoutingModule, { imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__.RouterModule], exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__.RouterModule] }); })();


/***/ }),

/***/ 4018:
/*!****************************************!*\
  !*** ./src/app/home/home.component.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "HomeComponent": () => (/* binding */ HomeComponent)
/* harmony export */ });
/* harmony import */ var _models__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @models */ 3150);
/* harmony import */ var _swimlane_ngx_datatable__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @swimlane/ngx-datatable */ 5582);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ 4001);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/forms */ 8346);
/* harmony import */ var _services__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @services */ 5988);






class HomeComponent {
    constructor(fb, trackService) {
        this.fb = fb;
        this.trackService = trackService;
        this.columns = [
            { prop: 'name' },
            {
                name: 'Albulm title',
                prop: 'albumTitle'
            },
            {
                name: 'Media type',
                prop: 'mediaTypeName'
            },
            {
                name: 'Genre',
                prop: 'genreName'
            },
            {
                name: 'Composer',
                prop: 'composer'
            }
        ];
        this.ColumnMode = _swimlane_ngx_datatable__WEBPACK_IMPORTED_MODULE_2__.ColumnMode;
    }
    ;
    ngOnInit() {
        this.page = new _models__WEBPACK_IMPORTED_MODULE_0__.Page();
        this.setPage(this.page);
    }
    setPage(page) {
        this.page.offset = page.offset;
        this.trackService.getTracks(page).subscribe((result) => {
            this.tracks = result.data;
            this.page = result.page;
        });
    }
    clear() { }
    search() { }
}
HomeComponent.ɵfac = function HomeComponent_Factory(t) { return new (t || HomeComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_angular_forms__WEBPACK_IMPORTED_MODULE_4__.FormBuilder), _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_1__.TrackService)); };
HomeComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdefineComponent"]({ type: HomeComponent, selectors: [["app-home"]], decls: 2, vars: 9, consts: [[1, "row"], ["rowHeight", "auto", 1, "material", 3, "rows", "columns", "columnMode", "headerHeight", "footerHeight", "externalPaging", "count", "offset", "limit", "page"]], template: function HomeComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](1, "ngx-datatable", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵlistener"]("page", function HomeComponent_Template_ngx_datatable_page_1_listener($event) { return ctx.setPage($event); });
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("rows", ctx.tracks)("columns", ctx.columns)("columnMode", ctx.ColumnMode.force)("headerHeight", 50)("footerHeight", 50)("externalPaging", true)("count", ctx.page.count)("offset", ctx.page.offset)("limit", ctx.page.limit);
    } }, directives: [_swimlane_ngx_datatable__WEBPACK_IMPORTED_MODULE_2__.DatatableComponent], styles: [".search-results[_ngcontent-%COMP%] {\n  display: grid;\n  grid-gap: 0.5em 0.5em;\n  width: 100%;\n}\n\n.list-resulte[_ngcontent-%COMP%] {\n  grid-template-columns: 1fr;\n}\n\n.tile-results[_ngcontent-%COMP%] {\n  grid-template-columns: repeat(3, 1fr);\n}\n\n.search-results[_ngcontent-%COMP%]    > *[_ngcontent-%COMP%] {\n  background-color: #f8f8f8;\n  padding: 0.5em;\n}\n\n.search-results[_ngcontent-%COMP%]    > *[_ngcontent-%COMP%]   h5[_ngcontent-%COMP%] {\n  text-align: center;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImhvbWUuY29tcG9uZW50LnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDSSxhQUFBO0VBQ0EscUJBQUE7RUFDQSxXQUFBO0FBQ0o7O0FBR0E7RUFDSSwwQkFBQTtBQUFKOztBQUdBO0VBQ0kscUNBQUE7QUFBSjs7QUFHQTtFQUVJLHlCQUFBO0VBQ0EsY0FBQTtBQURKOztBQUdJO0VBQ0ksa0JBQUE7QUFEUiIsImZpbGUiOiJob21lLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLnNlYXJjaC1yZXN1bHRzIHtcclxuICAgIGRpc3BsYXk6IGdyaWQ7XHJcbiAgICBncmlkLWdhcDogMC41ZW0gMC41ZW07XHJcbiAgICB3aWR0aDoxMDAlO1xyXG4gICAgLy8gYmFja2dyb3VuZC1jb2xvcjogY29ybmZsb3dlcmJsdWU7XHJcbn1cclxuXHJcbi5saXN0LXJlc3VsdGV7XHJcbiAgICBncmlkLXRlbXBsYXRlLWNvbHVtbnM6IDFmcjtcclxufVxyXG5cclxuLnRpbGUtcmVzdWx0c3tcclxuICAgIGdyaWQtdGVtcGxhdGUtY29sdW1uczogcmVwZWF0KDMsIDFmcik7XHJcbn1cclxuXHJcbi5zZWFyY2gtcmVzdWx0cyA+ICoge1xyXG5cclxuICAgIGJhY2tncm91bmQtY29sb3I6IHJnYigyNDgsIDI0OCwgMjQ4KTtcclxuICAgIHBhZGRpbmc6IDAuNWVtO1xyXG5cclxuICAgIGg1IHtcclxuICAgICAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbiAgICAgICAgXHJcbiAgICB9XHJcbn1cclxuIl19 */"] });


/***/ }),

/***/ 8245:
/*!*************************************!*\
  !*** ./src/app/home/home.module.ts ***!
  \*************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "HomeModule": () => (/* binding */ HomeModule)
/* harmony export */ });
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common */ 8267);
/* harmony import */ var _shared__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @shared */ 1265);
/* harmony import */ var _home_routing_module__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./home-routing.module */ 3949);
/* harmony import */ var _home_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./home.component */ 4018);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ 4001);





//import { ViewDetailComponent } from './view-detail/view-detail.component';
class HomeModule {
}
HomeModule.ɵfac = function HomeModule_Factory(t) { return new (t || HomeModule)(); };
HomeModule.ɵmod = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdefineNgModule"]({ type: HomeModule });
HomeModule.ɵinj = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdefineInjector"]({ imports: [[_angular_common__WEBPACK_IMPORTED_MODULE_4__.CommonModule, _home_routing_module__WEBPACK_IMPORTED_MODULE_1__.HomeRoutingModule, _shared__WEBPACK_IMPORTED_MODULE_0__.SharedModule]] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵsetNgModuleScope"](HomeModule, { declarations: [_home_component__WEBPACK_IMPORTED_MODULE_2__.HomeComponent
        //  , ViewDetailComponent
    ], imports: [_angular_common__WEBPACK_IMPORTED_MODULE_4__.CommonModule, _home_routing_module__WEBPACK_IMPORTED_MODULE_1__.HomeRoutingModule, _shared__WEBPACK_IMPORTED_MODULE_0__.SharedModule] }); })();


/***/ }),

/***/ 3235:
/*!****************************************!*\
  !*** ./src/app/shared/models/album.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Album": () => (/* binding */ Album)
/* harmony export */ });
class Album {
}


/***/ }),

/***/ 9095:
/*!*****************************************!*\
  !*** ./src/app/shared/models/artist.ts ***!
  \*****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Artist": () => (/* binding */ Artist)
/* harmony export */ });
class Artist {
}


/***/ }),

/***/ 4213:
/*!*******************************************!*\
  !*** ./src/app/shared/models/customer.ts ***!
  \*******************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Customer": () => (/* binding */ Customer)
/* harmony export */ });
class Customer {
}


/***/ }),

/***/ 528:
/*!*******************************************!*\
  !*** ./src/app/shared/models/employee.ts ***!
  \*******************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Employee": () => (/* binding */ Employee)
/* harmony export */ });
class Employee {
}


/***/ }),

/***/ 6650:
/*!****************************************!*\
  !*** ./src/app/shared/models/genre.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Genre": () => (/* binding */ Genre)
/* harmony export */ });
class Genre {
}


/***/ }),

/***/ 3150:
/*!****************************************!*\
  !*** ./src/app/shared/models/index.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Album": () => (/* reexport safe */ _album__WEBPACK_IMPORTED_MODULE_0__.Album),
/* harmony export */   "Artist": () => (/* reexport safe */ _artist__WEBPACK_IMPORTED_MODULE_1__.Artist),
/* harmony export */   "Customer": () => (/* reexport safe */ _customer__WEBPACK_IMPORTED_MODULE_2__.Customer),
/* harmony export */   "Employee": () => (/* reexport safe */ _employee__WEBPACK_IMPORTED_MODULE_3__.Employee),
/* harmony export */   "Genre": () => (/* reexport safe */ _genre__WEBPACK_IMPORTED_MODULE_4__.Genre),
/* harmony export */   "Invoice": () => (/* reexport safe */ _invoice__WEBPACK_IMPORTED_MODULE_5__.Invoice),
/* harmony export */   "InvoiceItem": () => (/* reexport safe */ _invoice_item__WEBPACK_IMPORTED_MODULE_6__.InvoiceItem),
/* harmony export */   "MediaType": () => (/* reexport safe */ _media_type__WEBPACK_IMPORTED_MODULE_7__.MediaType),
/* harmony export */   "Page": () => (/* reexport safe */ _page__WEBPACK_IMPORTED_MODULE_8__.Page),
/* harmony export */   "Playlist": () => (/* reexport safe */ _playlist__WEBPACK_IMPORTED_MODULE_9__.Playlist),
/* harmony export */   "PlaylistTrack": () => (/* reexport safe */ _playlist_track__WEBPACK_IMPORTED_MODULE_10__.PlaylistTrack),
/* harmony export */   "Track": () => (/* reexport safe */ _track__WEBPACK_IMPORTED_MODULE_11__.Track)
/* harmony export */ });
/* harmony import */ var _album__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./album */ 3235);
/* harmony import */ var _artist__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./artist */ 9095);
/* harmony import */ var _customer__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./customer */ 4213);
/* harmony import */ var _employee__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./employee */ 528);
/* harmony import */ var _genre__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./genre */ 6650);
/* harmony import */ var _invoice__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./invoice */ 4641);
/* harmony import */ var _invoice_item__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./invoice_item */ 2602);
/* harmony import */ var _media_type__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./media_type */ 7871);
/* harmony import */ var _page__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./page */ 7358);
/* harmony import */ var _playlist__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./playlist */ 4007);
/* harmony import */ var _playlist_track__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./playlist_track */ 7426);
/* harmony import */ var _track__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./track */ 1475);














/***/ }),

/***/ 4641:
/*!******************************************!*\
  !*** ./src/app/shared/models/invoice.ts ***!
  \******************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Invoice": () => (/* binding */ Invoice)
/* harmony export */ });
class Invoice {
}


/***/ }),

/***/ 2602:
/*!***********************************************!*\
  !*** ./src/app/shared/models/invoice_item.ts ***!
  \***********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "InvoiceItem": () => (/* binding */ InvoiceItem)
/* harmony export */ });
class InvoiceItem {
}


/***/ }),

/***/ 7871:
/*!*********************************************!*\
  !*** ./src/app/shared/models/media_type.ts ***!
  \*********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "MediaType": () => (/* binding */ MediaType)
/* harmony export */ });
class MediaType {
}


/***/ }),

/***/ 7358:
/*!***************************************!*\
  !*** ./src/app/shared/models/page.ts ***!
  \***************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Page": () => (/* binding */ Page)
/* harmony export */ });
class Page {
    constructor() {
        this.limit = 0;
        this.offset = 0;
        this.count = 0;
        this.next = 0;
        this.previous = 0;
    }
}


/***/ }),

/***/ 4007:
/*!*******************************************!*\
  !*** ./src/app/shared/models/playlist.ts ***!
  \*******************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Playlist": () => (/* binding */ Playlist)
/* harmony export */ });
class Playlist {
}


/***/ }),

/***/ 7426:
/*!*************************************************!*\
  !*** ./src/app/shared/models/playlist_track.ts ***!
  \*************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "PlaylistTrack": () => (/* binding */ PlaylistTrack)
/* harmony export */ });
class PlaylistTrack {
}


/***/ }),

/***/ 1475:
/*!****************************************!*\
  !*** ./src/app/shared/models/track.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Track": () => (/* binding */ Track)
/* harmony export */ });
class Track {
}


/***/ })

}]);
//# sourceMappingURL=src_app_home_home_module_ts.js.map