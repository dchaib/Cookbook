"use strict";

var gulp = require('gulp');

var paths = {
    webroot: "./wwwroot/",
    bower: "./bower_components/"
};

paths.lib = paths.webroot + "lib/";

gulp.task("copy:lib", function () {
    var bower = {
        "bootstrap": "bootstrap/dist/**/*.{js,map,css,ttf,svg,woff,woff2,eot}",
        "jquery": "jquery/dist/jquery*.{js,map}",
        "jquery-validation": "jquery-validation/dist/jquery.validate*.js",
        "jquery-validation-unobtrusive": "jquery-validation-unobtrusive/jquery.validate.unobtrusive*.js",
        "knockout.js": "knockout.js/knockout.js"
    }

    for (var destinationDir in bower) {
        gulp.src(paths.bower + bower[destinationDir])
          .pipe(gulp.dest(paths.lib + destinationDir));
    }
});