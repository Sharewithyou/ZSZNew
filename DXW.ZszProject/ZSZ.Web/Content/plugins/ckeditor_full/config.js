/**
 * @license Copyright (c) 2003-2018, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function (config) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
	// config.uiColor = '#AADC6E';

	config.allowedContent = true;

	config.toolbar = [
		{ name: 'document', items: ['Source', '-', 'Save'] },
		{ name: 'tools', items: ['Maximize', 'ShowBlocks'] }

	];
	// config.disallowedContent = 'script; *[on*];';

	// config.allowedContent = {
	// 	$1: {			
	// 		elements: CKEDITOR.dtd,
	// 		attributes: true,
	// 		styles: true,
	// 		classes: true
	// 	}
	// };
	// config.disallowedContent = 'script; *[on*]';

};


