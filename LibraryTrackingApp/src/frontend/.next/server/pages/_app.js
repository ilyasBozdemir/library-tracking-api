/*
 * ATTENTION: An "eval-source-map" devtool has been used.
 * This devtool is neither made for production nor for readable output files.
 * It uses "eval()" calls to create a separate source file with attached SourceMaps in the browser devtools.
 * If you are trying to read the output file, select a different devtool (https://webpack.js.org/configuration/devtool/)
 * or disable the default devtool with "devtool: false".
 * If you are looking for production-ready output files, see mode: "production" (https://webpack.js.org/configuration/mode/).
 */
(() => {
var exports = {};
exports.id = "pages/_app";
exports.ids = ["pages/_app"];
exports.modules = {

/***/ "./pages/_app.jsx":
/*!************************!*\
  !*** ./pages/_app.jsx ***!
  \************************/
/***/ ((module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.a(module, async (__webpack_handle_async_dependencies__, __webpack_async_result__) => { try {\n__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   \"default\": () => (__WEBPACK_DEFAULT_EXPORT__)\n/* harmony export */ });\n/* harmony import */ var react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react/jsx-dev-runtime */ \"react/jsx-dev-runtime\");\n/* harmony import */ var react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__);\n/* harmony import */ var _chakra_ui_react__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @chakra-ui/react */ \"@chakra-ui/react\");\n/* harmony import */ var next_dynamic__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! next/dynamic */ \"./node_modules/next/dynamic.js\");\n/* harmony import */ var next_dynamic__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(next_dynamic__WEBPACK_IMPORTED_MODULE_2__);\n/* harmony import */ var _src_theme__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../src/theme */ \"./src/theme.js\");\n/* harmony import */ var _styles_globals_css__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../styles/globals.css */ \"./styles/globals.css\");\n/* harmony import */ var _styles_globals_css__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_styles_globals_css__WEBPACK_IMPORTED_MODULE_4__);\n/* harmony import */ var aos__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! aos */ \"aos\");\n/* harmony import */ var aos__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(aos__WEBPACK_IMPORTED_MODULE_5__);\n/* harmony import */ var aos_dist_aos_css__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! aos/dist/aos.css */ \"./node_modules/aos/dist/aos.css\");\n/* harmony import */ var aos_dist_aos_css__WEBPACK_IMPORTED_MODULE_6___default = /*#__PURE__*/__webpack_require__.n(aos_dist_aos_css__WEBPACK_IMPORTED_MODULE_6__);\n/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! next/router */ \"./node_modules/next/router.js\");\n/* harmony import */ var next_router__WEBPACK_IMPORTED_MODULE_7___default = /*#__PURE__*/__webpack_require__.n(next_router__WEBPACK_IMPORTED_MODULE_7__);\n/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! react */ \"react\");\n/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_8___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_8__);\nvar __webpack_async_dependencies__ = __webpack_handle_async_dependencies__([_chakra_ui_react__WEBPACK_IMPORTED_MODULE_1__, _src_theme__WEBPACK_IMPORTED_MODULE_3__]);\n([_chakra_ui_react__WEBPACK_IMPORTED_MODULE_1__, _src_theme__WEBPACK_IMPORTED_MODULE_3__] = __webpack_async_dependencies__.then ? (await __webpack_async_dependencies__)() : __webpack_async_dependencies__);\n\n\n\nconst UserLayout = next_dynamic__WEBPACK_IMPORTED_MODULE_2___default()(()=>Promise.all(/*! import() */[__webpack_require__.e(\"vendor-chunks/next\"), __webpack_require__.e(\"vendor-chunks/react-icons\"), __webpack_require__.e(\"layouts_UserLayout_jsx\")]).then(__webpack_require__.bind(__webpack_require__, /*! @/layouts/UserLayout */ \"./layouts/UserLayout.jsx\")), {\n    loadableGenerated: {\n        modules: [\n            \"_app.jsx -> \" + \"@/layouts/UserLayout\"\n        ]\n    }\n});\nconst AdminLayout = next_dynamic__WEBPACK_IMPORTED_MODULE_2___default()(()=>Promise.all(/*! import() */[__webpack_require__.e(\"vendor-chunks/next\"), __webpack_require__.e(\"vendor-chunks/react-icons\"), __webpack_require__.e(\"layouts_AdminLayout_jsx\")]).then(__webpack_require__.bind(__webpack_require__, /*! @/layouts/AdminLayout */ \"./layouts/AdminLayout.jsx\")), {\n    loadableGenerated: {\n        modules: [\n            \"_app.jsx -> \" + \"@/layouts/AdminLayout\"\n        ]\n    }\n});\nconst ErrorLayout = next_dynamic__WEBPACK_IMPORTED_MODULE_2___default()(()=>__webpack_require__.e(/*! import() */ \"layouts_ErrorLayout_jsx\").then(__webpack_require__.bind(__webpack_require__, /*! @/layouts/ErrorLayout */ \"./layouts/ErrorLayout.jsx\")), {\n    loadableGenerated: {\n        modules: [\n            \"_app.jsx -> \" + \"@/layouts/ErrorLayout\"\n        ]\n    }\n});\nconst EmptyLayout = next_dynamic__WEBPACK_IMPORTED_MODULE_2___default()(()=>__webpack_require__.e(/*! import() */ \"layouts_EmptyLayout_jsx\").then(__webpack_require__.bind(__webpack_require__, /*! @/layouts/EmptyLayout */ \"./layouts/EmptyLayout.jsx\")), {\n    loadableGenerated: {\n        modules: [\n            \"_app.jsx -> \" + \"@/layouts/EmptyLayout\"\n        ]\n    }\n});\n\n\n\n\n\n\nfunction MyApp({ Component, pageProps, session, statusCode }) {\n    const data = {};\n    let Layout;\n    const router = (0,next_router__WEBPACK_IMPORTED_MODULE_7__.useRouter)();\n    if (router.pathname === \"/\") {\n        Layout = UserLayout;\n    } else if (router.pathname.startsWith(\"/admin\")) {\n        Layout = AdminLayout;\n    } else if (router.pathname === \"/login\") {\n        Layout = EmptyLayout;\n    } else if (router.pathname === \"/api-docs\") {\n        Layout = EmptyLayout;\n    } else {\n        Layout = UserLayout;\n    }\n    (0,react__WEBPACK_IMPORTED_MODULE_8__.useEffect)(()=>{\n        aos__WEBPACK_IMPORTED_MODULE_5___default().init({\n            duration: 1000,\n            once: true,\n            easing: \"ease-out-back\"\n        });\n        aos__WEBPACK_IMPORTED_MODULE_5___default().refresh();\n    }, []);\n    return /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.Fragment, {\n        children: [\n            /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.Fragment, {\n                children: [\n                    401,\n                    403,\n                    404,\n                    500,\n                    501\n                ].includes(statusCode) ? /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.Fragment, {\n                    children: /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(ErrorLayout, {\n                        statusCode: statusCode\n                    }, void 0, false, {\n                        fileName: \"D:\\\\Github\\\\Cases\\\\libraryTrackingApp\\\\LibraryTrackingApp\\\\src\\\\frontend\\\\pages\\\\_app.jsx\",\n                        lineNumber: 47,\n                        columnNumber: 13\n                    }, this)\n                }, void 0, false) : /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.Fragment, {\n                    children: /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(_chakra_ui_react__WEBPACK_IMPORTED_MODULE_1__.ChakraProvider, {\n                        theme: _src_theme__WEBPACK_IMPORTED_MODULE_3__[\"default\"],\n                        resetCSS: true,\n                        children: /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(Layout, {\n                            children: /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(Component, {\n                                ...pageProps\n                            }, void 0, false, {\n                                fileName: \"D:\\\\Github\\\\Cases\\\\libraryTrackingApp\\\\LibraryTrackingApp\\\\src\\\\frontend\\\\pages\\\\_app.jsx\",\n                                lineNumber: 53,\n                                columnNumber: 17\n                            }, this)\n                        }, void 0, false, {\n                            fileName: \"D:\\\\Github\\\\Cases\\\\libraryTrackingApp\\\\LibraryTrackingApp\\\\src\\\\frontend\\\\pages\\\\_app.jsx\",\n                            lineNumber: 52,\n                            columnNumber: 15\n                        }, this)\n                    }, void 0, false, {\n                        fileName: \"D:\\\\Github\\\\Cases\\\\libraryTrackingApp\\\\LibraryTrackingApp\\\\src\\\\frontend\\\\pages\\\\_app.jsx\",\n                        lineNumber: 51,\n                        columnNumber: 13\n                    }, this)\n                }, void 0, false)\n            }, void 0, false),\n            /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.Fragment, {}, void 0, false)\n        ]\n    }, void 0, true);\n}\nMyApp.getInitialProps = async (appContext)=>{\n    const { Component, ctx } = appContext;\n    let pageProps = {};\n    let session = {};\n    if (Component.getInitialProps) {\n        pageProps = await Component.getInitialProps(ctx);\n        session = await Component.getInitialProps(ctx);\n    }\n    const { res, err } = ctx;\n    const statusCode = res ? res.statusCode : err ? err.statusCode : null;\n    return {\n        pageProps,\n        session,\n        statusCode\n    };\n};\n/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (MyApp);\n\n__webpack_async_result__();\n} catch(e) { __webpack_async_result__(e); } });//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9wYWdlcy9fYXBwLmpzeCIsIm1hcHBpbmdzIjoiOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7QUFBa0Q7QUFDZjtBQUVuQyxNQUFNRSxhQUFhRCxtREFBT0EsQ0FBQyxJQUFNLDBSQUE4Qjs7Ozs7OztBQUMvRCxNQUFNRSxjQUFjRixtREFBT0EsQ0FBQyxJQUFNLDZSQUErQjs7Ozs7OztBQUNqRSxNQUFNRyxjQUFjSCxtREFBT0EsQ0FBQyxJQUFNLDhLQUErQjs7Ozs7OztBQUNqRSxNQUFNSSxjQUFjSixtREFBT0EsQ0FBQyxJQUFNLDhLQUErQjs7Ozs7OztBQUVoQztBQUNGO0FBQ1Q7QUFDSTtBQUNjO0FBQ047QUFDbEMsU0FBU1MsTUFBTSxFQUFFQyxTQUFTLEVBQUVDLFNBQVMsRUFBRUMsT0FBTyxFQUFFQyxVQUFVLEVBQUU7SUFDMUQsTUFBTUMsT0FBTyxDQUFDO0lBQ2QsSUFBSUM7SUFDSixNQUFNQyxTQUFTVCxzREFBU0E7SUFDeEIsSUFBSVMsT0FBT0MsUUFBUSxLQUFLLEtBQUs7UUFDM0JGLFNBQVNkO0lBQ1gsT0FBTyxJQUFJZSxPQUFPQyxRQUFRLENBQUNDLFVBQVUsQ0FBQyxXQUFXO1FBQy9DSCxTQUFTYjtJQUNYLE9BQU8sSUFBSWMsT0FBT0MsUUFBUSxLQUFLLFVBQVU7UUFDdkNGLFNBQVNYO0lBQ1gsT0FDSyxJQUFJWSxPQUFPQyxRQUFRLEtBQUssYUFBYTtRQUN4Q0YsU0FBU1g7SUFDWCxPQUNLO1FBQ0hXLFNBQVNkO0lBQ1g7SUFFQU8sZ0RBQVNBLENBQUM7UUFDUkYsK0NBQVEsQ0FBQztZQUNQYyxVQUFVO1lBQ1ZDLE1BQU07WUFDTkMsUUFBUTtRQUNWO1FBQ0FoQixrREFBVztJQUNiLEdBQUcsRUFBRTtJQUVMLHFCQUNFOzswQkFDRTswQkFDRztvQkFBQztvQkFBSztvQkFBSztvQkFBSztvQkFBSztpQkFBSSxDQUFDa0IsUUFBUSxDQUFDWCw0QkFDbEM7OEJBQ0UsNEVBQUNWO3dCQUFZVSxZQUFZQTs7Ozs7O2tEQUczQjs4QkFDRSw0RUFBQ2QsNERBQWNBO3dCQUFDTSxPQUFPQSxrREFBS0E7d0JBQUVvQixRQUFRO2tDQUNwQyw0RUFBQ1Y7c0NBQ0MsNEVBQUNMO2dDQUFXLEdBQUdDLFNBQVM7Ozs7Ozs7Ozs7Ozs7Ozs7OzswQkFPbEM7OztBQUdOO0FBRUFGLE1BQU1pQixlQUFlLEdBQUcsT0FBT0M7SUFDN0IsTUFBTSxFQUFFakIsU0FBUyxFQUFFa0IsR0FBRyxFQUFFLEdBQUdEO0lBQzNCLElBQUloQixZQUFZLENBQUM7SUFDakIsSUFBSUMsVUFBVSxDQUFDO0lBRWYsSUFBSUYsVUFBVWdCLGVBQWUsRUFBRTtRQUM3QmYsWUFBWSxNQUFNRCxVQUFVZ0IsZUFBZSxDQUFDRTtRQUM1Q2hCLFVBQVUsTUFBTUYsVUFBVWdCLGVBQWUsQ0FBQ0U7SUFDNUM7SUFFQSxNQUFNLEVBQUVDLEdBQUcsRUFBRUMsR0FBRyxFQUFFLEdBQUdGO0lBQ3JCLE1BQU1mLGFBQWFnQixNQUFNQSxJQUFJaEIsVUFBVSxHQUFHaUIsTUFBTUEsSUFBSWpCLFVBQVUsR0FBRztJQUVqRSxPQUFPO1FBQUVGO1FBQVdDO1FBQVNDO0lBQVc7QUFDMUM7QUFFQSxpRUFBZUosS0FBS0EsRUFBQyIsInNvdXJjZXMiOlsid2VicGFjazovL2xpYnJhcnktdHJhY2tpbmctYXBwLXVpLy4vcGFnZXMvX2FwcC5qc3g/NGNiMyJdLCJzb3VyY2VzQ29udGVudCI6WyJpbXBvcnQgeyBDaGFrcmFQcm92aWRlciB9IGZyb20gXCJAY2hha3JhLXVpL3JlYWN0XCI7XHJcbmltcG9ydCBkeW5hbWljIGZyb20gXCJuZXh0L2R5bmFtaWNcIjtcclxuXHJcbmNvbnN0IFVzZXJMYXlvdXQgPSBkeW5hbWljKCgpID0+IGltcG9ydChcIkAvbGF5b3V0cy9Vc2VyTGF5b3V0XCIpKTtcclxuY29uc3QgQWRtaW5MYXlvdXQgPSBkeW5hbWljKCgpID0+IGltcG9ydChcIkAvbGF5b3V0cy9BZG1pbkxheW91dFwiKSk7XHJcbmNvbnN0IEVycm9yTGF5b3V0ID0gZHluYW1pYygoKSA9PiBpbXBvcnQoXCJAL2xheW91dHMvRXJyb3JMYXlvdXRcIikpO1xyXG5jb25zdCBFbXB0eUxheW91dCA9IGR5bmFtaWMoKCkgPT4gaW1wb3J0KFwiQC9sYXlvdXRzL0VtcHR5TGF5b3V0XCIpKTtcclxuXHJcbmltcG9ydCB0aGVtZSBmcm9tIFwiLi4vc3JjL3RoZW1lXCI7XHJcbmltcG9ydCBcIi4uL3N0eWxlcy9nbG9iYWxzLmNzc1wiO1xyXG5pbXBvcnQgQU9TIGZyb20gXCJhb3NcIjtcclxuaW1wb3J0IFwiYW9zL2Rpc3QvYW9zLmNzc1wiO1xyXG5pbXBvcnQgeyB1c2VSb3V0ZXIgfSBmcm9tIFwibmV4dC9yb3V0ZXJcIjtcclxuaW1wb3J0IHsgdXNlRWZmZWN0IH0gZnJvbSBcInJlYWN0XCI7XHJcbmZ1bmN0aW9uIE15QXBwKHsgQ29tcG9uZW50LCBwYWdlUHJvcHMsIHNlc3Npb24sIHN0YXR1c0NvZGUgfSkge1xyXG4gIGNvbnN0IGRhdGEgPSB7fTtcclxuICBsZXQgTGF5b3V0O1xyXG4gIGNvbnN0IHJvdXRlciA9IHVzZVJvdXRlcigpO1xyXG4gIGlmIChyb3V0ZXIucGF0aG5hbWUgPT09IFwiL1wiKSB7XHJcbiAgICBMYXlvdXQgPSBVc2VyTGF5b3V0O1xyXG4gIH0gZWxzZSBpZiAocm91dGVyLnBhdGhuYW1lLnN0YXJ0c1dpdGgoXCIvYWRtaW5cIikpIHtcclxuICAgIExheW91dCA9IEFkbWluTGF5b3V0O1xyXG4gIH0gZWxzZSBpZiAocm91dGVyLnBhdGhuYW1lID09PSBcIi9sb2dpblwiKSB7XHJcbiAgICBMYXlvdXQgPSBFbXB0eUxheW91dDtcclxuICB9IFxyXG4gIGVsc2UgaWYgKHJvdXRlci5wYXRobmFtZSA9PT0gXCIvYXBpLWRvY3NcIikge1xyXG4gICAgTGF5b3V0ID0gRW1wdHlMYXlvdXQ7XHJcbiAgfSBcclxuICBlbHNlIHtcclxuICAgIExheW91dCA9IFVzZXJMYXlvdXQ7XHJcbiAgfVxyXG5cclxuICB1c2VFZmZlY3QoKCkgPT4ge1xyXG4gICAgQU9TLmluaXQoe1xyXG4gICAgICBkdXJhdGlvbjogMTAwMCxcclxuICAgICAgb25jZTogdHJ1ZSxcclxuICAgICAgZWFzaW5nOiBcImVhc2Utb3V0LWJhY2tcIixcclxuICAgIH0pO1xyXG4gICAgQU9TLnJlZnJlc2goKTtcclxuICB9LCBbXSk7XHJcblxyXG4gIHJldHVybiAoXHJcbiAgICA8PlxyXG4gICAgICA8PlxyXG4gICAgICAgIHtbNDAxLCA0MDMsIDQwNCwgNTAwLCA1MDFdLmluY2x1ZGVzKHN0YXR1c0NvZGUpID8gKFxyXG4gICAgICAgICAgPD5cclxuICAgICAgICAgICAgPEVycm9yTGF5b3V0IHN0YXR1c0NvZGU9e3N0YXR1c0NvZGV9IC8+XHJcbiAgICAgICAgICA8Lz5cclxuICAgICAgICApIDogKFxyXG4gICAgICAgICAgPD5cclxuICAgICAgICAgICAgPENoYWtyYVByb3ZpZGVyIHRoZW1lPXt0aGVtZX0gcmVzZXRDU1M+XHJcbiAgICAgICAgICAgICAgPExheW91dD5cclxuICAgICAgICAgICAgICAgIDxDb21wb25lbnQgey4uLnBhZ2VQcm9wc30gLz5cclxuICAgICAgICAgICAgICA8L0xheW91dD5cclxuICAgICAgICAgICAgPC9DaGFrcmFQcm92aWRlcj5cclxuICAgICAgICAgIDwvPlxyXG4gICAgICAgICl9XHJcbiAgICAgIDwvPlxyXG5cclxuICAgICAgPD48Lz5cclxuICAgIDwvPlxyXG4gICk7XHJcbn1cclxuXHJcbk15QXBwLmdldEluaXRpYWxQcm9wcyA9IGFzeW5jIChhcHBDb250ZXh0KSA9PiB7XHJcbiAgY29uc3QgeyBDb21wb25lbnQsIGN0eCB9ID0gYXBwQ29udGV4dDtcclxuICBsZXQgcGFnZVByb3BzID0ge307XHJcbiAgbGV0IHNlc3Npb24gPSB7fTtcclxuXHJcbiAgaWYgKENvbXBvbmVudC5nZXRJbml0aWFsUHJvcHMpIHtcclxuICAgIHBhZ2VQcm9wcyA9IGF3YWl0IENvbXBvbmVudC5nZXRJbml0aWFsUHJvcHMoY3R4KTtcclxuICAgIHNlc3Npb24gPSBhd2FpdCBDb21wb25lbnQuZ2V0SW5pdGlhbFByb3BzKGN0eCk7XHJcbiAgfVxyXG5cclxuICBjb25zdCB7IHJlcywgZXJyIH0gPSBjdHg7XHJcbiAgY29uc3Qgc3RhdHVzQ29kZSA9IHJlcyA/IHJlcy5zdGF0dXNDb2RlIDogZXJyID8gZXJyLnN0YXR1c0NvZGUgOiBudWxsO1xyXG5cclxuICByZXR1cm4geyBwYWdlUHJvcHMsIHNlc3Npb24sIHN0YXR1c0NvZGUgfTtcclxufTtcclxuXHJcbmV4cG9ydCBkZWZhdWx0IE15QXBwOyJdLCJuYW1lcyI6WyJDaGFrcmFQcm92aWRlciIsImR5bmFtaWMiLCJVc2VyTGF5b3V0IiwiQWRtaW5MYXlvdXQiLCJFcnJvckxheW91dCIsIkVtcHR5TGF5b3V0IiwidGhlbWUiLCJBT1MiLCJ1c2VSb3V0ZXIiLCJ1c2VFZmZlY3QiLCJNeUFwcCIsIkNvbXBvbmVudCIsInBhZ2VQcm9wcyIsInNlc3Npb24iLCJzdGF0dXNDb2RlIiwiZGF0YSIsIkxheW91dCIsInJvdXRlciIsInBhdGhuYW1lIiwic3RhcnRzV2l0aCIsImluaXQiLCJkdXJhdGlvbiIsIm9uY2UiLCJlYXNpbmciLCJyZWZyZXNoIiwiaW5jbHVkZXMiLCJyZXNldENTUyIsImdldEluaXRpYWxQcm9wcyIsImFwcENvbnRleHQiLCJjdHgiLCJyZXMiLCJlcnIiXSwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./pages/_app.jsx\n");

/***/ }),

/***/ "./src/foundations/breakpoints.jsx":
/*!*****************************************!*\
  !*** ./src/foundations/breakpoints.jsx ***!
  \*****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   breakpoints: () => (/* binding */ breakpoints)\n/* harmony export */ });\nconst breakpoints = {\n    base: \"20em\",\n    sm: \"30em\",\n    md: \"64em\",\n    lg: \"68em\",\n    xl: \"80em\",\n    \"2xl\": \"96em\",\n    \"3xl\": \"112em\",\n    \"4xl\": \"128em\",\n    \"5xl\": \"144em\",\n    \"6xl\": \"160em\",\n    \"7xl\": \"176em\"\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvYnJlYWtwb2ludHMuanN4IiwibWFwcGluZ3MiOiI7Ozs7QUFBTyxNQUFNQSxjQUFjO0lBQ3pCQyxNQUFNO0lBQ05DLElBQUk7SUFDSkMsSUFBSTtJQUNKQyxJQUFJO0lBQ0pDLElBQUk7SUFDSixPQUFPO0lBQ1AsT0FBTztJQUNQLE9BQU87SUFDUCxPQUFPO0lBQ1AsT0FBTztJQUNQLE9BQU87QUFDVCxFQUFFIiwic291cmNlcyI6WyJ3ZWJwYWNrOi8vbGlicmFyeS10cmFja2luZy1hcHAtdWkvLi9zcmMvZm91bmRhdGlvbnMvYnJlYWtwb2ludHMuanN4PzYxOWMiXSwic291cmNlc0NvbnRlbnQiOlsiZXhwb3J0IGNvbnN0IGJyZWFrcG9pbnRzID0ge1xyXG4gIGJhc2U6IFwiMjBlbVwiLCAvLyAzMjBcclxuICBzbTogXCIzMGVtXCIsIC8vIDQ4MFxyXG4gIG1kOiBcIjY0ZW1cIiwgLy8gMTAyNFxyXG4gIGxnOiBcIjY4ZW1cIiwgLy8gMTA4OFxyXG4gIHhsOiBcIjgwZW1cIiwgLy8gMTI4MFxyXG4gIFwiMnhsXCI6IFwiOTZlbVwiLCAvLyAxNTM2XHJcbiAgXCIzeGxcIjogXCIxMTJlbVwiLCAvLyAxNzkyXHJcbiAgXCI0eGxcIjogXCIxMjhlbVwiLCAvLyAyMDQ4XHJcbiAgXCI1eGxcIjogXCIxNDRlbVwiLCAvLyAyMzA0XHJcbiAgXCI2eGxcIjogXCIxNjBlbVwiLCAvLyAyNTYwXHJcbiAgXCI3eGxcIjogXCIxNzZlbVwiLCAvLyAyODE2XHJcbn07XHJcbiJdLCJuYW1lcyI6WyJicmVha3BvaW50cyIsImJhc2UiLCJzbSIsIm1kIiwibGciLCJ4bCJdLCJzb3VyY2VSb290IjoiIn0=\n//# sourceURL=webpack-internal:///./src/foundations/breakpoints.jsx\n");

/***/ }),

/***/ "./src/foundations/colors.jsx":
/*!************************************!*\
  !*** ./src/foundations/colors.jsx ***!
  \************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   colors: () => (/* binding */ colors)\n/* harmony export */ });\nconst colors = {\n    white: \"#ffffff\",\n    black: \"#000000\",\n    //whiten\n    primary: {\n        100: \"#54BEC3\",\n        200: \"#30a1a6\",\n        300: \"#005f65\"\n    },\n    accent: {\n        100: \"#c354be\",\n        200: \"#ffecff\"\n    },\n    text: {\n        100: \"#333333\",\n        200: \"#5c5c5c\"\n    },\n    bg: {\n        100: \"#F5F5F5\",\n        200: \"#ebebeb\",\n        300: \"#c2c2c2\"\n    },\n    //darken\n    primaryD: {\n        100: \"#61DAFB\",\n        200: \"#39bcdc\",\n        300: \"#007997\"\n    },\n    accentD: {\n        100: \"#c354be\",\n        200: \"#ffecff\"\n    },\n    textD: {\n        100: \"#FFFFFF\",\n        200: \"#e0e0e0\"\n    },\n    bgD: {\n        100: \"#282C34\",\n        200: \"#383c44\",\n        300: \"#50555e\"\n    }\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvY29sb3JzLmpzeCIsIm1hcHBpbmdzIjoiOzs7O0FBQU8sTUFBTUEsU0FBUztJQUNwQkMsT0FBTztJQUNQQyxPQUFPO0lBRVAsUUFBUTtJQUVSQyxTQUFTO1FBQ1AsS0FBSztRQUNMLEtBQUs7UUFDTCxLQUFLO0lBQ1A7SUFDQUMsUUFBUTtRQUNOLEtBQUs7UUFDTCxLQUFLO0lBQ1A7SUFDQUMsTUFBTTtRQUNKLEtBQUs7UUFDTCxLQUFLO0lBQ1A7SUFDQUMsSUFBSTtRQUNGLEtBQUs7UUFDTCxLQUFLO1FBQ0wsS0FBSztJQUNQO0lBRUEsUUFBUTtJQUNSQyxVQUFVO1FBQ1IsS0FBSztRQUNMLEtBQUs7UUFDTCxLQUFLO0lBQ1A7SUFDQUMsU0FBUztRQUNQLEtBQUs7UUFDTCxLQUFLO0lBQ1A7SUFDQUMsT0FBTztRQUNMLEtBQUs7UUFDTCxLQUFLO0lBQ1A7SUFDQUMsS0FBSztRQUNILEtBQUs7UUFDTCxLQUFLO1FBQ0wsS0FBSztJQUNQO0FBQ0YsRUFBRSIsInNvdXJjZXMiOlsid2VicGFjazovL2xpYnJhcnktdHJhY2tpbmctYXBwLXVpLy4vc3JjL2ZvdW5kYXRpb25zL2NvbG9ycy5qc3g/ZTI0NyJdLCJzb3VyY2VzQ29udGVudCI6WyJleHBvcnQgY29uc3QgY29sb3JzID0ge1xyXG4gIHdoaXRlOiBcIiNmZmZmZmZcIixcclxuICBibGFjazogXCIjMDAwMDAwXCIsXHJcblxyXG4gIC8vd2hpdGVuXHJcblxyXG4gIHByaW1hcnk6IHtcclxuICAgIDEwMDogXCIjNTRCRUMzXCIsXHJcbiAgICAyMDA6IFwiIzMwYTFhNlwiLFxyXG4gICAgMzAwOiBcIiMwMDVmNjVcIixcclxuICB9LFxyXG4gIGFjY2VudDoge1xyXG4gICAgMTAwOiBcIiNjMzU0YmVcIixcclxuICAgIDIwMDogXCIjZmZlY2ZmXCIsXHJcbiAgfSxcclxuICB0ZXh0OiB7XHJcbiAgICAxMDA6IFwiIzMzMzMzM1wiLFxyXG4gICAgMjAwOiBcIiM1YzVjNWNcIixcclxuICB9LFxyXG4gIGJnOiB7XHJcbiAgICAxMDA6IFwiI0Y1RjVGNVwiLFxyXG4gICAgMjAwOiBcIiNlYmViZWJcIixcclxuICAgIDMwMDogXCIjYzJjMmMyXCIsXHJcbiAgfSxcclxuXHJcbiAgLy9kYXJrZW5cclxuICBwcmltYXJ5RDoge1xyXG4gICAgMTAwOiBcIiM2MURBRkJcIixcclxuICAgIDIwMDogXCIjMzliY2RjXCIsXHJcbiAgICAzMDA6IFwiIzAwNzk5N1wiLFxyXG4gIH0sXHJcbiAgYWNjZW50RDoge1xyXG4gICAgMTAwOiBcIiNjMzU0YmVcIixcclxuICAgIDIwMDogXCIjZmZlY2ZmXCIsXHJcbiAgfSxcclxuICB0ZXh0RDoge1xyXG4gICAgMTAwOiBcIiNGRkZGRkZcIixcclxuICAgIDIwMDogXCIjZTBlMGUwXCIsXHJcbiAgfSxcclxuICBiZ0Q6IHtcclxuICAgIDEwMDogXCIjMjgyQzM0XCIsXHJcbiAgICAyMDA6IFwiIzM4M2M0NFwiLFxyXG4gICAgMzAwOiBcIiM1MDU1NWVcIixcclxuICB9LFxyXG59O1xyXG4iXSwibmFtZXMiOlsiY29sb3JzIiwid2hpdGUiLCJibGFjayIsInByaW1hcnkiLCJhY2NlbnQiLCJ0ZXh0IiwiYmciLCJwcmltYXJ5RCIsImFjY2VudEQiLCJ0ZXh0RCIsImJnRCJdLCJzb3VyY2VSb290IjoiIn0=\n//# sourceURL=webpack-internal:///./src/foundations/colors.jsx\n");

/***/ }),

/***/ "./src/foundations/config.jsx":
/*!************************************!*\
  !*** ./src/foundations/config.jsx ***!
  \************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   config: () => (/* binding */ config)\n/* harmony export */ });\nconst config = {\n    initialColorMode: \"light\",\n    useSystemColorMode: true,\n    cssVarPrefix: \"appiz-software\"\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvY29uZmlnLmpzeCIsIm1hcHBpbmdzIjoiOzs7O0FBQU8sTUFBTUEsU0FBUztJQUNwQkMsa0JBQWtCO0lBQ2xCQyxvQkFBb0I7SUFDcEJDLGNBQWM7QUFDaEIsRUFBRSIsInNvdXJjZXMiOlsid2VicGFjazovL2xpYnJhcnktdHJhY2tpbmctYXBwLXVpLy4vc3JjL2ZvdW5kYXRpb25zL2NvbmZpZy5qc3g/ODNlNCJdLCJzb3VyY2VzQ29udGVudCI6WyJleHBvcnQgY29uc3QgY29uZmlnID0ge1xyXG4gIGluaXRpYWxDb2xvck1vZGU6IFwibGlnaHRcIixcclxuICB1c2VTeXN0ZW1Db2xvck1vZGU6IHRydWUsXHJcbiAgY3NzVmFyUHJlZml4OiBcImFwcGl6LXNvZnR3YXJlXCIsXHJcbn07XHJcbiJdLCJuYW1lcyI6WyJjb25maWciLCJpbml0aWFsQ29sb3JNb2RlIiwidXNlU3lzdGVtQ29sb3JNb2RlIiwiY3NzVmFyUHJlZml4Il0sInNvdXJjZVJvb3QiOiIifQ==\n//# sourceURL=webpack-internal:///./src/foundations/config.jsx\n");

/***/ }),

/***/ "./src/foundations/fontSizes.jsx":
/*!***************************************!*\
  !*** ./src/foundations/fontSizes.jsx ***!
  \***************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   fontSizes: () => (/* binding */ fontSizes)\n/* harmony export */ });\nconst fontSizes = {\n    xs: \"12px\",\n    sm: \"14px\",\n    md: \"16px\",\n    lg: \"18px\",\n    xl: \"20px\",\n    \"2xl\": \"24px\",\n    \"3xl\": \"28px\",\n    \"4xl\": \"36px\",\n    \"5xl\": \"48px\",\n    \"6xl\": \"64px\"\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvZm9udFNpemVzLmpzeCIsIm1hcHBpbmdzIjoiOzs7O0FBQU8sTUFBTUEsWUFBWTtJQUNyQkMsSUFBSTtJQUNKQyxJQUFJO0lBQ0pDLElBQUk7SUFDSkMsSUFBSTtJQUNKQyxJQUFJO0lBQ0osT0FBTztJQUNQLE9BQU87SUFDUCxPQUFPO0lBQ1AsT0FBTztJQUNQLE9BQU87QUFDWCxFQUFFIiwic291cmNlcyI6WyJ3ZWJwYWNrOi8vbGlicmFyeS10cmFja2luZy1hcHAtdWkvLi9zcmMvZm91bmRhdGlvbnMvZm9udFNpemVzLmpzeD82NGU1Il0sInNvdXJjZXNDb250ZW50IjpbImV4cG9ydCBjb25zdCBmb250U2l6ZXMgPSB7XHJcbiAgICB4czogXCIxMnB4XCIsXHJcbiAgICBzbTogXCIxNHB4XCIsXHJcbiAgICBtZDogXCIxNnB4XCIsXHJcbiAgICBsZzogXCIxOHB4XCIsXHJcbiAgICB4bDogXCIyMHB4XCIsXHJcbiAgICBcIjJ4bFwiOiBcIjI0cHhcIixcclxuICAgIFwiM3hsXCI6IFwiMjhweFwiLFxyXG4gICAgXCI0eGxcIjogXCIzNnB4XCIsXHJcbiAgICBcIjV4bFwiOiBcIjQ4cHhcIixcclxuICAgIFwiNnhsXCI6IFwiNjRweFwiLFxyXG59O1xyXG4iXSwibmFtZXMiOlsiZm9udFNpemVzIiwieHMiLCJzbSIsIm1kIiwibGciLCJ4bCJdLCJzb3VyY2VSb290IjoiIn0=\n//# sourceURL=webpack-internal:///./src/foundations/fontSizes.jsx\n");

/***/ }),

/***/ "./src/foundations/fontWeights.jsx":
/*!*****************************************!*\
  !*** ./src/foundations/fontWeights.jsx ***!
  \*****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   fontWeights: () => (/* binding */ fontWeights)\n/* harmony export */ });\nconst fontWeights = {\n    normal: 400,\n    medium: 500,\n    bold: 700\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvZm9udFdlaWdodHMuanN4IiwibWFwcGluZ3MiOiI7Ozs7QUFBTyxNQUFNQSxjQUFjO0lBQ3ZCQyxRQUFRO0lBQ1JDLFFBQVE7SUFDUkMsTUFBTTtBQUNWLEVBQUUiLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly9saWJyYXJ5LXRyYWNraW5nLWFwcC11aS8uL3NyYy9mb3VuZGF0aW9ucy9mb250V2VpZ2h0cy5qc3g/MDM4OSJdLCJzb3VyY2VzQ29udGVudCI6WyJleHBvcnQgY29uc3QgZm9udFdlaWdodHMgPSB7XHJcbiAgICBub3JtYWw6IDQwMCxcclxuICAgIG1lZGl1bTogNTAwLFxyXG4gICAgYm9sZDogNzAwLFxyXG59OyJdLCJuYW1lcyI6WyJmb250V2VpZ2h0cyIsIm5vcm1hbCIsIm1lZGl1bSIsImJvbGQiXSwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./src/foundations/fontWeights.jsx\n");

/***/ }),

/***/ "./src/foundations/fonts.jsx":
/*!***********************************!*\
  !*** ./src/foundations/fonts.jsx ***!
  \***********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   fonts: () => (/* binding */ fonts)\n/* harmony export */ });\nconst fonts = {\n    body: \"system-ui, -apple-system, BlinkMacSystemFont, Segoe UI, Roboto, Oxygen, Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, sans-serif\",\n    heading: \"Georgia, serif\",\n    mono: \"Menlo, monospace\"\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvZm9udHMuanN4IiwibWFwcGluZ3MiOiI7Ozs7QUFBTyxNQUFNQSxRQUFRO0lBQ2pCQyxNQUFNO0lBQ05DLFNBQVM7SUFDVEMsTUFBTTtBQUNWLEVBQUUiLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly9saWJyYXJ5LXRyYWNraW5nLWFwcC11aS8uL3NyYy9mb3VuZGF0aW9ucy9mb250cy5qc3g/NDAyMyJdLCJzb3VyY2VzQ29udGVudCI6WyJleHBvcnQgY29uc3QgZm9udHMgPSB7XHJcbiAgICBib2R5OiBcInN5c3RlbS11aSwgLWFwcGxlLXN5c3RlbSwgQmxpbmtNYWNTeXN0ZW1Gb250LCBTZWdvZSBVSSwgUm9ib3RvLCBPeHlnZW4sIFVidW50dSwgQ2FudGFyZWxsLCBGaXJhIFNhbnMsIERyb2lkIFNhbnMsIEhlbHZldGljYSBOZXVlLCBzYW5zLXNlcmlmXCIsXHJcbiAgICBoZWFkaW5nOiBcIkdlb3JnaWEsIHNlcmlmXCIsXHJcbiAgICBtb25vOiBcIk1lbmxvLCBtb25vc3BhY2VcIixcclxufTtcclxuIl0sIm5hbWVzIjpbImZvbnRzIiwiYm9keSIsImhlYWRpbmciLCJtb25vIl0sInNvdXJjZVJvb3QiOiIifQ==\n//# sourceURL=webpack-internal:///./src/foundations/fonts.jsx\n");

/***/ }),

/***/ "./src/foundations/letterSpacings.jsx":
/*!********************************************!*\
  !*** ./src/foundations/letterSpacings.jsx ***!
  \********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   letterSpacings: () => (/* binding */ letterSpacings)\n/* harmony export */ });\nconst letterSpacings = {\n    tighter: \"-0.05em\",\n    tight: \"-0.025em\",\n    normal: \"0\",\n    wide: \"0.025em\",\n    wider: \"0.05em\",\n    widest: \"0.1em\"\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvbGV0dGVyU3BhY2luZ3MuanN4IiwibWFwcGluZ3MiOiI7Ozs7QUFDTyxNQUFNQSxpQkFBaUI7SUFDMUJDLFNBQVM7SUFDVEMsT0FBTztJQUNQQyxRQUFRO0lBQ1JDLE1BQU07SUFDTkMsT0FBTztJQUNQQyxRQUFRO0FBQ1osRUFBRSIsInNvdXJjZXMiOlsid2VicGFjazovL2xpYnJhcnktdHJhY2tpbmctYXBwLXVpLy4vc3JjL2ZvdW5kYXRpb25zL2xldHRlclNwYWNpbmdzLmpzeD9kNGExIl0sInNvdXJjZXNDb250ZW50IjpbIlxyXG5leHBvcnQgY29uc3QgbGV0dGVyU3BhY2luZ3MgPSB7XHJcbiAgICB0aWdodGVyOiBcIi0wLjA1ZW1cIixcclxuICAgIHRpZ2h0OiBcIi0wLjAyNWVtXCIsXHJcbiAgICBub3JtYWw6IFwiMFwiLFxyXG4gICAgd2lkZTogXCIwLjAyNWVtXCIsXHJcbiAgICB3aWRlcjogXCIwLjA1ZW1cIixcclxuICAgIHdpZGVzdDogXCIwLjFlbVwiLFxyXG59O1xyXG4iXSwibmFtZXMiOlsibGV0dGVyU3BhY2luZ3MiLCJ0aWdodGVyIiwidGlnaHQiLCJub3JtYWwiLCJ3aWRlIiwid2lkZXIiLCJ3aWRlc3QiXSwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./src/foundations/letterSpacings.jsx\n");

/***/ }),

/***/ "./src/foundations/lineHeights.jsx":
/*!*****************************************!*\
  !*** ./src/foundations/lineHeights.jsx ***!
  \*****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   lineHeights: () => (/* binding */ lineHeights)\n/* harmony export */ });\nconst lineHeights = {\n    normal: \"normal\",\n    none: \"1\",\n    shorter: \"1.25\",\n    short: \"1.375\",\n    base: \"1.5\",\n    tall: \"1.625\",\n    taller: \"2\"\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvbGluZUhlaWdodHMuanN4IiwibWFwcGluZ3MiOiI7Ozs7QUFBTyxNQUFNQSxjQUFjO0lBQ3ZCQyxRQUFRO0lBQ1JDLE1BQU07SUFDTkMsU0FBUztJQUNUQyxPQUFPO0lBQ1BDLE1BQU07SUFDTkMsTUFBTTtJQUNOQyxRQUFRO0FBQ1osRUFBRSIsInNvdXJjZXMiOlsid2VicGFjazovL2xpYnJhcnktdHJhY2tpbmctYXBwLXVpLy4vc3JjL2ZvdW5kYXRpb25zL2xpbmVIZWlnaHRzLmpzeD80ZGE1Il0sInNvdXJjZXNDb250ZW50IjpbImV4cG9ydCBjb25zdCBsaW5lSGVpZ2h0cyA9IHtcclxuICAgIG5vcm1hbDogXCJub3JtYWxcIixcclxuICAgIG5vbmU6IFwiMVwiLFxyXG4gICAgc2hvcnRlcjogXCIxLjI1XCIsXHJcbiAgICBzaG9ydDogXCIxLjM3NVwiLFxyXG4gICAgYmFzZTogXCIxLjVcIixcclxuICAgIHRhbGw6IFwiMS42MjVcIixcclxuICAgIHRhbGxlcjogXCIyXCIsXHJcbn07XHJcbiJdLCJuYW1lcyI6WyJsaW5lSGVpZ2h0cyIsIm5vcm1hbCIsIm5vbmUiLCJzaG9ydGVyIiwic2hvcnQiLCJiYXNlIiwidGFsbCIsInRhbGxlciJdLCJzb3VyY2VSb290IjoiIn0=\n//# sourceURL=webpack-internal:///./src/foundations/lineHeights.jsx\n");

/***/ }),

/***/ "./src/foundations/sizes.jsx":
/*!***********************************!*\
  !*** ./src/foundations/sizes.jsx ***!
  \***********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   sizes: () => (/* binding */ sizes)\n/* harmony export */ });\nconst sizes = {\n    full: \"100%\",\n    \"3xs\": \"14rem\",\n    \"2xs\": \"16rem\",\n    xs: \"20rem\",\n    sm: \"24rem\",\n    md: \"28rem\",\n    lg: \"32rem\",\n    xl: \"36rem\",\n    \"2xl\": \"42rem\",\n    \"3xl\": \"48rem\",\n    \"4xl\": \"56rem\",\n    \"5xl\": \"64rem\",\n    \"6xl\": \"72rem\"\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvc2l6ZXMuanN4IiwibWFwcGluZ3MiOiI7Ozs7QUFBTyxNQUFNQSxRQUFRO0lBQ2pCQyxNQUFNO0lBQ04sT0FBTztJQUNQLE9BQU87SUFDUEMsSUFBSTtJQUNKQyxJQUFJO0lBQ0pDLElBQUk7SUFDSkMsSUFBSTtJQUNKQyxJQUFJO0lBQ0osT0FBTztJQUNQLE9BQU87SUFDUCxPQUFPO0lBQ1AsT0FBTztJQUNQLE9BQU87QUFDVCxFQUFDIiwic291cmNlcyI6WyJ3ZWJwYWNrOi8vbGlicmFyeS10cmFja2luZy1hcHAtdWkvLi9zcmMvZm91bmRhdGlvbnMvc2l6ZXMuanN4PzhjNGYiXSwic291cmNlc0NvbnRlbnQiOlsiZXhwb3J0IGNvbnN0IHNpemVzID0ge1xyXG4gICAgZnVsbDogXCIxMDAlXCIsXHJcbiAgICBcIjN4c1wiOiBcIjE0cmVtXCIsXHJcbiAgICBcIjJ4c1wiOiBcIjE2cmVtXCIsXHJcbiAgICB4czogXCIyMHJlbVwiLFxyXG4gICAgc206IFwiMjRyZW1cIixcclxuICAgIG1kOiBcIjI4cmVtXCIsXHJcbiAgICBsZzogXCIzMnJlbVwiLFxyXG4gICAgeGw6IFwiMzZyZW1cIixcclxuICAgIFwiMnhsXCI6IFwiNDJyZW1cIixcclxuICAgIFwiM3hsXCI6IFwiNDhyZW1cIixcclxuICAgIFwiNHhsXCI6IFwiNTZyZW1cIixcclxuICAgIFwiNXhsXCI6IFwiNjRyZW1cIixcclxuICAgIFwiNnhsXCI6IFwiNzJyZW1cIixcclxuICB9XHJcbiAgICAgIl0sIm5hbWVzIjpbInNpemVzIiwiZnVsbCIsInhzIiwic20iLCJtZCIsImxnIiwieGwiXSwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./src/foundations/sizes.jsx\n");

/***/ }),

/***/ "./src/foundations/space.jsx":
/*!***********************************!*\
  !*** ./src/foundations/space.jsx ***!
  \***********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   space: () => (/* binding */ space)\n/* harmony export */ });\nconst space = {\n    0: \"0\",\n    1: \"0.25rem\",\n    2: \"0.5rem\",\n    3: \"0.75rem\",\n    4: \"1rem\",\n    5: \"1.25rem\",\n    6: \"1.5rem\",\n    8: \"2rem\",\n    10: \"2.5rem\",\n    12: \"3rem\",\n    16: \"4rem\",\n    20: \"5rem\",\n    24: \"6rem\",\n    32: \"8rem\",\n    40: \"10rem\",\n    48: \"12rem\",\n    56: \"14rem\",\n    64: \"16rem\"\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvc3BhY2UuanN4IiwibWFwcGluZ3MiOiI7Ozs7QUFBTyxNQUFNQSxRQUFRO0lBQ25CLEdBQUc7SUFDSCxHQUFHO0lBQ0gsR0FBRztJQUNILEdBQUc7SUFDSCxHQUFHO0lBQ0gsR0FBRztJQUNILEdBQUc7SUFDSCxHQUFHO0lBQ0gsSUFBSTtJQUNKLElBQUk7SUFDSixJQUFJO0lBQ0osSUFBSTtJQUNKLElBQUk7SUFDSixJQUFJO0lBQ0osSUFBSTtJQUNKLElBQUk7SUFDSixJQUFJO0lBQ0osSUFBSTtBQUNOLEVBQUMiLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly9saWJyYXJ5LXRyYWNraW5nLWFwcC11aS8uL3NyYy9mb3VuZGF0aW9ucy9zcGFjZS5qc3g/YmU1NyJdLCJzb3VyY2VzQ29udGVudCI6WyJleHBvcnQgY29uc3Qgc3BhY2UgPSB7XHJcbiAgMDogXCIwXCIsXHJcbiAgMTogXCIwLjI1cmVtXCIsXHJcbiAgMjogXCIwLjVyZW1cIixcclxuICAzOiBcIjAuNzVyZW1cIixcclxuICA0OiBcIjFyZW1cIixcclxuICA1OiBcIjEuMjVyZW1cIixcclxuICA2OiBcIjEuNXJlbVwiLFxyXG4gIDg6IFwiMnJlbVwiLFxyXG4gIDEwOiBcIjIuNXJlbVwiLFxyXG4gIDEyOiBcIjNyZW1cIixcclxuICAxNjogXCI0cmVtXCIsXHJcbiAgMjA6IFwiNXJlbVwiLFxyXG4gIDI0OiBcIjZyZW1cIixcclxuICAzMjogXCI4cmVtXCIsXHJcbiAgNDA6IFwiMTByZW1cIixcclxuICA0ODogXCIxMnJlbVwiLFxyXG4gIDU2OiBcIjE0cmVtXCIsXHJcbiAgNjQ6IFwiMTZyZW1cIixcclxufVxyXG4gICAgICAiXSwibmFtZXMiOlsic3BhY2UiXSwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./src/foundations/space.jsx\n");

/***/ }),

/***/ "./src/foundations/styles.jsx":
/*!************************************!*\
  !*** ./src/foundations/styles.jsx ***!
  \************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   styles: () => (/* binding */ styles)\n/* harmony export */ });\nconst styles = {\n    global: (props)=>({\n            \"html, body\": {\n                padding: 0,\n                margin: 0,\n                height: \"100%\",\n                fontFamily: `-apple-system, BlinkMacSystemFont, Segoe UI, Roboto, Oxygen,\r\n        Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, sans-serif`,\n                fontSize: \"16px\"\n            }\n        })\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvc3R5bGVzLmpzeCIsIm1hcHBpbmdzIjoiOzs7O0FBQU8sTUFBTUEsU0FBUztJQUNwQkMsUUFBUSxDQUFDQyxRQUFXO1lBQ2xCLGNBQWM7Z0JBQ1pDLFNBQVM7Z0JBQ1RDLFFBQVE7Z0JBQ1JDLFFBQVE7Z0JBQ1JDLFlBQVksQ0FBQzs0RUFDeUQsQ0FBQztnQkFDdkVDLFVBQVU7WUFDWjtRQUNGO0FBQ0YsRUFBRSIsInNvdXJjZXMiOlsid2VicGFjazovL2xpYnJhcnktdHJhY2tpbmctYXBwLXVpLy4vc3JjL2ZvdW5kYXRpb25zL3N0eWxlcy5qc3g/NmRhYSJdLCJzb3VyY2VzQ29udGVudCI6WyJleHBvcnQgY29uc3Qgc3R5bGVzID0ge1xyXG4gIGdsb2JhbDogKHByb3BzKSA9PiAoe1xyXG4gICAgXCJodG1sLCBib2R5XCI6IHtcclxuICAgICAgcGFkZGluZzogMCxcclxuICAgICAgbWFyZ2luOiAwLFxyXG4gICAgICBoZWlnaHQ6IFwiMTAwJVwiLFxyXG4gICAgICBmb250RmFtaWx5OiBgLWFwcGxlLXN5c3RlbSwgQmxpbmtNYWNTeXN0ZW1Gb250LCBTZWdvZSBVSSwgUm9ib3RvLCBPeHlnZW4sXHJcbiAgICAgICAgVWJ1bnR1LCBDYW50YXJlbGwsIEZpcmEgU2FucywgRHJvaWQgU2FucywgSGVsdmV0aWNhIE5ldWUsIHNhbnMtc2VyaWZgLFxyXG4gICAgICBmb250U2l6ZTogXCIxNnB4XCIsXHJcbiAgICB9LFxyXG4gIH0pLFxyXG59O1xyXG4iXSwibmFtZXMiOlsic3R5bGVzIiwiZ2xvYmFsIiwicHJvcHMiLCJwYWRkaW5nIiwibWFyZ2luIiwiaGVpZ2h0IiwiZm9udEZhbWlseSIsImZvbnRTaXplIl0sInNvdXJjZVJvb3QiOiIifQ==\n//# sourceURL=webpack-internal:///./src/foundations/styles.jsx\n");

/***/ }),

/***/ "./src/foundations/zIndices.jsx":
/*!**************************************!*\
  !*** ./src/foundations/zIndices.jsx ***!
  \**************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   zIndices: () => (/* binding */ zIndices)\n/* harmony export */ });\nconst zIndices = {\n    hide: -1,\n    auto: \"auto\",\n    base: 0,\n    docked: 10,\n    dropdown: 1000,\n    sticky: 1100,\n    banner: 1200,\n    overlay: 1300,\n    modal: 1400,\n    popover: 1500,\n    skipLink: 1600,\n    toast: 1700\n};\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvZm91bmRhdGlvbnMvekluZGljZXMuanN4IiwibWFwcGluZ3MiOiI7Ozs7QUFBTyxNQUFNQSxXQUFXO0lBQ3RCQyxNQUFNLENBQUM7SUFDUEMsTUFBTTtJQUNOQyxNQUFNO0lBQ05DLFFBQVE7SUFDUkMsVUFBVTtJQUNWQyxRQUFRO0lBQ1JDLFFBQVE7SUFDUkMsU0FBUztJQUNUQyxPQUFPO0lBQ1BDLFNBQVM7SUFDVEMsVUFBVTtJQUNWQyxPQUFPO0FBQ1QsRUFBRSIsInNvdXJjZXMiOlsid2VicGFjazovL2xpYnJhcnktdHJhY2tpbmctYXBwLXVpLy4vc3JjL2ZvdW5kYXRpb25zL3pJbmRpY2VzLmpzeD80ZjlmIl0sInNvdXJjZXNDb250ZW50IjpbImV4cG9ydCBjb25zdCB6SW5kaWNlcyA9IHtcclxuICBoaWRlOiAtMSxcclxuICBhdXRvOiBcImF1dG9cIixcclxuICBiYXNlOiAwLFxyXG4gIGRvY2tlZDogMTAsXHJcbiAgZHJvcGRvd246IDEwMDAsXHJcbiAgc3RpY2t5OiAxMTAwLFxyXG4gIGJhbm5lcjogMTIwMCxcclxuICBvdmVybGF5OiAxMzAwLFxyXG4gIG1vZGFsOiAxNDAwLFxyXG4gIHBvcG92ZXI6IDE1MDAsXHJcbiAgc2tpcExpbms6IDE2MDAsXHJcbiAgdG9hc3Q6IDE3MDAsXHJcbn07XHJcbiJdLCJuYW1lcyI6WyJ6SW5kaWNlcyIsImhpZGUiLCJhdXRvIiwiYmFzZSIsImRvY2tlZCIsImRyb3Bkb3duIiwic3RpY2t5IiwiYmFubmVyIiwib3ZlcmxheSIsIm1vZGFsIiwicG9wb3ZlciIsInNraXBMaW5rIiwidG9hc3QiXSwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./src/foundations/zIndices.jsx\n");

/***/ }),

/***/ "./src/theme.js":
/*!**********************!*\
  !*** ./src/theme.js ***!
  \**********************/
/***/ ((module, __webpack_exports__, __webpack_require__) => {

"use strict";
eval("__webpack_require__.a(module, async (__webpack_handle_async_dependencies__, __webpack_async_result__) => { try {\n__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   \"default\": () => (__WEBPACK_DEFAULT_EXPORT__)\n/* harmony export */ });\n/* harmony import */ var _chakra_ui_react__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @chakra-ui/react */ \"@chakra-ui/react\");\n/* harmony import */ var _foundations_styles__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./foundations/styles */ \"./src/foundations/styles.jsx\");\n/* harmony import */ var _foundations_config__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./foundations/config */ \"./src/foundations/config.jsx\");\n/* harmony import */ var _foundations_colors__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./foundations/colors */ \"./src/foundations/colors.jsx\");\n/* harmony import */ var _foundations_fonts__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./foundations/fonts */ \"./src/foundations/fonts.jsx\");\n/* harmony import */ var _foundations_fontSizes__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./foundations/fontSizes */ \"./src/foundations/fontSizes.jsx\");\n/* harmony import */ var _foundations_fontWeights__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./foundations/fontWeights */ \"./src/foundations/fontWeights.jsx\");\n/* harmony import */ var _foundations_lineHeights__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./foundations/lineHeights */ \"./src/foundations/lineHeights.jsx\");\n/* harmony import */ var _foundations_letterSpacings__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./foundations/letterSpacings */ \"./src/foundations/letterSpacings.jsx\");\n/* harmony import */ var _foundations_breakpoints__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./foundations/breakpoints */ \"./src/foundations/breakpoints.jsx\");\n/* harmony import */ var _foundations_space__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./foundations/space */ \"./src/foundations/space.jsx\");\n/* harmony import */ var _foundations_sizes__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./foundations/sizes */ \"./src/foundations/sizes.jsx\");\n/* harmony import */ var _foundations_zIndices__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./foundations/zIndices */ \"./src/foundations/zIndices.jsx\");\nvar __webpack_async_dependencies__ = __webpack_handle_async_dependencies__([_chakra_ui_react__WEBPACK_IMPORTED_MODULE_0__]);\n_chakra_ui_react__WEBPACK_IMPORTED_MODULE_0__ = (__webpack_async_dependencies__.then ? (await __webpack_async_dependencies__)() : __webpack_async_dependencies__)[0];\n\n\n\n\n\n\n\n\n\n\n\n\n\nconst theme = (0,_chakra_ui_react__WEBPACK_IMPORTED_MODULE_0__.extendTheme)({\n    styles: _foundations_styles__WEBPACK_IMPORTED_MODULE_1__.styles,\n    config: _foundations_config__WEBPACK_IMPORTED_MODULE_2__.config,\n    colors: _foundations_colors__WEBPACK_IMPORTED_MODULE_3__.colors,\n    fonts: _foundations_fonts__WEBPACK_IMPORTED_MODULE_4__.fonts,\n    fontSizes: _foundations_fontSizes__WEBPACK_IMPORTED_MODULE_5__.fontSizes,\n    fontWeights: _foundations_fontWeights__WEBPACK_IMPORTED_MODULE_6__.fontWeights,\n    lineHeights: _foundations_lineHeights__WEBPACK_IMPORTED_MODULE_7__.lineHeights,\n    letterSpacings: _foundations_letterSpacings__WEBPACK_IMPORTED_MODULE_8__.letterSpacings,\n    breakpoints: _foundations_breakpoints__WEBPACK_IMPORTED_MODULE_9__.breakpoints,\n    //shadows,\n    space: _foundations_space__WEBPACK_IMPORTED_MODULE_10__.space,\n    sizes: _foundations_sizes__WEBPACK_IMPORTED_MODULE_11__.sizes,\n    zIndices: _foundations_zIndices__WEBPACK_IMPORTED_MODULE_12__.zIndices\n});\n/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (theme);\n\n__webpack_async_result__();\n} catch(e) { __webpack_async_result__(e); } });//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9zcmMvdGhlbWUuanMiLCJtYXBwaW5ncyI6Ijs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7QUFBK0M7QUFDRDtBQUNBO0FBQ0E7QUFDRjtBQUNRO0FBQ0k7QUFDQTtBQUNNO0FBQ047QUFDWjtBQUNBO0FBQ007QUFFbEQsTUFBTWEsUUFBUWIsNkRBQVdBLENBQUM7SUFDeEJDLE1BQU1BLHlEQUFBQTtJQUNOQyxNQUFNQSx5REFBQUE7SUFDTkMsTUFBTUEseURBQUFBO0lBQ05DLEtBQUtBLHVEQUFBQTtJQUNMQyxTQUFTQSwrREFBQUE7SUFDVEMsV0FBV0EsbUVBQUFBO0lBQ1hDLFdBQVdBLG1FQUFBQTtJQUNYQyxjQUFjQSx5RUFBQUE7SUFDZEMsV0FBV0EsbUVBQUFBO0lBQ1gsVUFBVTtJQUNWQyxLQUFLQSx3REFBQUE7SUFDTEMsS0FBS0Esd0RBQUFBO0lBQ0xDLFFBQVFBLDhEQUFBQTtBQUNWO0FBRUEsaUVBQWVDLEtBQUtBLEVBQUMiLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly9saWJyYXJ5LXRyYWNraW5nLWFwcC11aS8uL3NyYy90aGVtZS5qcz9hZmE0Il0sInNvdXJjZXNDb250ZW50IjpbImltcG9ydCB7IGV4dGVuZFRoZW1lIH0gZnJvbSBcIkBjaGFrcmEtdWkvcmVhY3RcIjtcclxuaW1wb3J0IHsgc3R5bGVzIH0gZnJvbSBcIi4vZm91bmRhdGlvbnMvc3R5bGVzXCI7XHJcbmltcG9ydCB7IGNvbmZpZyB9IGZyb20gXCIuL2ZvdW5kYXRpb25zL2NvbmZpZ1wiO1xyXG5pbXBvcnQgeyBjb2xvcnMgfSBmcm9tIFwiLi9mb3VuZGF0aW9ucy9jb2xvcnNcIjtcclxuaW1wb3J0IHsgZm9udHMgfSBmcm9tIFwiLi9mb3VuZGF0aW9ucy9mb250c1wiO1xyXG5pbXBvcnQgeyBmb250U2l6ZXMgfSBmcm9tIFwiLi9mb3VuZGF0aW9ucy9mb250U2l6ZXNcIjtcclxuaW1wb3J0IHsgZm9udFdlaWdodHMgfSBmcm9tIFwiLi9mb3VuZGF0aW9ucy9mb250V2VpZ2h0c1wiO1xyXG5pbXBvcnQgeyBsaW5lSGVpZ2h0cyB9IGZyb20gXCIuL2ZvdW5kYXRpb25zL2xpbmVIZWlnaHRzXCI7XHJcbmltcG9ydCB7IGxldHRlclNwYWNpbmdzIH0gZnJvbSBcIi4vZm91bmRhdGlvbnMvbGV0dGVyU3BhY2luZ3NcIjtcclxuaW1wb3J0IHsgYnJlYWtwb2ludHMgfSBmcm9tIFwiLi9mb3VuZGF0aW9ucy9icmVha3BvaW50c1wiO1xyXG5pbXBvcnQgeyBzcGFjZSB9IGZyb20gXCIuL2ZvdW5kYXRpb25zL3NwYWNlXCI7XHJcbmltcG9ydCB7IHNpemVzIH0gZnJvbSBcIi4vZm91bmRhdGlvbnMvc2l6ZXNcIjtcclxuaW1wb3J0IHsgekluZGljZXMgfSBmcm9tIFwiLi9mb3VuZGF0aW9ucy96SW5kaWNlc1wiO1xyXG5cclxuY29uc3QgdGhlbWUgPSBleHRlbmRUaGVtZSh7XHJcbiAgc3R5bGVzLFxyXG4gIGNvbmZpZyxcclxuICBjb2xvcnMsXHJcbiAgZm9udHMsXHJcbiAgZm9udFNpemVzLFxyXG4gIGZvbnRXZWlnaHRzLFxyXG4gIGxpbmVIZWlnaHRzLFxyXG4gIGxldHRlclNwYWNpbmdzLFxyXG4gIGJyZWFrcG9pbnRzLFxyXG4gIC8vc2hhZG93cyxcclxuICBzcGFjZSxcclxuICBzaXplcyxcclxuICB6SW5kaWNlcyxcclxufSk7XHJcblxyXG5leHBvcnQgZGVmYXVsdCB0aGVtZTtcclxuIl0sIm5hbWVzIjpbImV4dGVuZFRoZW1lIiwic3R5bGVzIiwiY29uZmlnIiwiY29sb3JzIiwiZm9udHMiLCJmb250U2l6ZXMiLCJmb250V2VpZ2h0cyIsImxpbmVIZWlnaHRzIiwibGV0dGVyU3BhY2luZ3MiLCJicmVha3BvaW50cyIsInNwYWNlIiwic2l6ZXMiLCJ6SW5kaWNlcyIsInRoZW1lIl0sInNvdXJjZVJvb3QiOiIifQ==\n//# sourceURL=webpack-internal:///./src/theme.js\n");

/***/ }),

/***/ "./styles/globals.css":
/*!****************************!*\
  !*** ./styles/globals.css ***!
  \****************************/
/***/ (() => {



/***/ }),

/***/ "aos":
/*!**********************!*\
  !*** external "aos" ***!
  \**********************/
/***/ ((module) => {

"use strict";
module.exports = require("aos");

/***/ }),

/***/ "next-i18next":
/*!*******************************!*\
  !*** external "next-i18next" ***!
  \*******************************/
/***/ ((module) => {

"use strict";
module.exports = require("next-i18next");

/***/ }),

/***/ "next/dist/compiled/next-server/pages.runtime.dev.js":
/*!**********************************************************************!*\
  !*** external "next/dist/compiled/next-server/pages.runtime.dev.js" ***!
  \**********************************************************************/
/***/ ((module) => {

"use strict";
module.exports = require("next/dist/compiled/next-server/pages.runtime.dev.js");

/***/ }),

/***/ "next/head":
/*!****************************!*\
  !*** external "next/head" ***!
  \****************************/
/***/ ((module) => {

"use strict";
module.exports = require("next/head");

/***/ }),

/***/ "react":
/*!************************!*\
  !*** external "react" ***!
  \************************/
/***/ ((module) => {

"use strict";
module.exports = require("react");

/***/ }),

/***/ "react-dom":
/*!****************************!*\
  !*** external "react-dom" ***!
  \****************************/
/***/ ((module) => {

"use strict";
module.exports = require("react-dom");

/***/ }),

/***/ "react/jsx-dev-runtime":
/*!****************************************!*\
  !*** external "react/jsx-dev-runtime" ***!
  \****************************************/
/***/ ((module) => {

"use strict";
module.exports = require("react/jsx-dev-runtime");

/***/ }),

/***/ "@chakra-ui/react":
/*!***********************************!*\
  !*** external "@chakra-ui/react" ***!
  \***********************************/
/***/ ((module) => {

"use strict";
module.exports = import("@chakra-ui/react");;

/***/ }),

/***/ "fs":
/*!*********************!*\
  !*** external "fs" ***!
  \*********************/
/***/ ((module) => {

"use strict";
module.exports = require("fs");

/***/ }),

/***/ "path":
/*!***********************!*\
  !*** external "path" ***!
  \***********************/
/***/ ((module) => {

"use strict";
module.exports = require("path");

/***/ }),

/***/ "stream":
/*!*************************!*\
  !*** external "stream" ***!
  \*************************/
/***/ ((module) => {

"use strict";
module.exports = require("stream");

/***/ }),

/***/ "zlib":
/*!***********************!*\
  !*** external "zlib" ***!
  \***********************/
/***/ ((module) => {

"use strict";
module.exports = require("zlib");

/***/ })

};
;

// load runtime
var __webpack_require__ = require("../webpack-runtime.js");
__webpack_require__.C(exports);
var __webpack_exec__ = (moduleId) => (__webpack_require__(__webpack_require__.s = moduleId))
var __webpack_exports__ = __webpack_require__.X(0, ["vendor-chunks/next","vendor-chunks/@swc","vendor-chunks/aos"], () => (__webpack_exec__("./pages/_app.jsx")));
module.exports = __webpack_exports__;

})();