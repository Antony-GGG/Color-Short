mergeInto(LibraryManager.library, {
    GoToURLInSameTab: function(url) {
        const urlParams = new URLSearchParams(window.location.search);
        var device_type = urlParams.get("device_type");

        if (device_type === "Android")
            window.JSBridge.receivedFromJS("GameOver");
        else if (device_type === "ios")
            window.webkit.messageHandlers.jsHandler.postMessage("GameOver");
        else
            window.location.reload();
    }

});
