function CallMethod() {
    DotNet.invokeMethodAsync("BlazorServerAppDemo", "GetValueFromMethod").then(result => {
        alert('Message from Method ' + result);
    });
}

export function CallInstanceMethod(instanceObj) {
    instanceObj.invokeMethodAsync("GetValueFromInstance").then(result => {
        alert('Message from Method ' + result);
    });
}