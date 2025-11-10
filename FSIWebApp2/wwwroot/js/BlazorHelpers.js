
    // This js function is called by the C# code in Blazor to trigger a file download.
    window.BlazorDownloadFile = function (filename, content) {

    // Create a temporary anchor element
    const link = document.createElement('a');

    // Create a Blob from the content with the correct MIME type
    const blob = new Blob([content], { type: 'text/csv;charset=utf-8;' });
    const url = URL.createObjectURL(blob);

    // Set the link's href and download attributes, then click it
    link.href = url;
    link.download = filename;
    document.body.appendChild(link);
    link.click();

    // Clean up by removing the temporary link and revoking the object URL
    document.body.removeChild(link);
    URL.revokeObjectURL(url);
};