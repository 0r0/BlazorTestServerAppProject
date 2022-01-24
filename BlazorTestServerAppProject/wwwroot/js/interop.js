function createAlert() {
    alert("Hey this is alert");
}

function createPrompt(question) {
    return prompt(question);
}

function setElementTextById(id, text) {
    document.getElementById(id).innerText = text;

}

function focusOnElement(element) {
    element.focus();
}
function giveMeRandomInt(maximumValue) {
    DotNet.invokeMethodAsync('BlazorTestServerAppProject', 'GenerateRandomInt', maximumValue)
        .then(result => setElementTextById('randomNumberSpan', result))
}

function giveMeRandomInt2(maximumValue2,dotnetInstance) {

    dotnetInstance.invokeMethodAsync('GenerateRandomInt', maximumValue2).then(result => {
        setElementTextById('randomNumberSpan2', Math.floor(Math.random(maximumValue2)))});
}