# OCR POC

## What's this?
Just a RD project for testing out OCR using Tesseract based on WinForms (phew, but it was the easy and quickest way).

## Setup and execution
Clone/download/what ever this project and fire it up in Visual Studio 2017. Make sure the C# workload has been fully installed before.
Restore Nuget packages and download required Tesseract data files here: 

https://github.com/tesseract-ocr/tessdata/archive/3.04.00.zip

Extract them somewhere and debug/build the application. Hit `Browse *.traineddata file` and select `eng.traineddata` (or what ever language basically) from the archive you've extracted.

Select an image by hitting `Select and scan image` and let OCR do their stuff. The output should be displayed right next to it.
