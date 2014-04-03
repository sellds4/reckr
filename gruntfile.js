'use strict';

module.exports = function(grunt) {

  // Project configuration.
  grunt.initConfig({
    pkg: grunt.file.readJSON('package.json'),
    jade: {
      html: {
        src: ['client/jade/partials/*.jade'],
        dest: ['client/app/partials']
      },
      options: {
        client: false,
        pretty: true,
        expand: true
      }
    },
    stylus: {
      compile: {
        files: {
          'app/css/master.css': ['app/stylus/*.styl']
        }
      }
    }
  });

  grunt.loadNpmTasks('grunt-contrib-stylus');
  grunt.loadNpmTasks('grunt-jade');

  // Default task(s).
  grunt.registerTask('default', ['jade', 'stylus'])
};