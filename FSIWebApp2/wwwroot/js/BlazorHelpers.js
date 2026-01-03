
            window.downloadFileFromStream = async (fileName, contentStreamReference) => {
            // 1. Get the data as an ArrayBuffer from the stream reference
            const arrayBuffer = await contentStreamReference.arrayBuffer();

            // 2. Create a Blob from the ArrayBuffer (Blob is memory efficient)
            const blob = new Blob([arrayBuffer]);

            // 3. Create a temporary URL for the Blob
            const url = URL.createObjectURL(blob);

            // 4. Create an anchor element to trigger the download
            const anchorElement = document.createElement('a');
            anchorElement.href = url;
            anchorElement.download = fileName ?? '';
            anchorElement.click(); // Trigger the browser download

            // 5. Clean up the temporary resources
            anchorElement.remove();
            URL.revokeObjectURL(url);
};

//Pevious version without steam functionality
//This js function is called by the C# code in Blazor to trigger a file download.
//window.BlazorDownloadFile = function (filename, content) {

//// Create a temporary anchor element
//const link = document.createElement('a');

//// Create a Blob from the content with the correct MIME type
//const blob = new Blob([content], { type: 'text/csv;charset=utf-8;' });
//const url = URL.createObjectURL(blob);

//// Set the link's href and download attributes, then click it
//link.href = url;
//link.download = filename;
//document.body.appendChild(link);
//link.click();

//// Clean up by removing the temporary link and revoking the object URL
//document.body.removeChild(link);
//    URL.revokeObjectURL(url);