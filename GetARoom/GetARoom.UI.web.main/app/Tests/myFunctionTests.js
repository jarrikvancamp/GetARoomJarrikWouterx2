
//suite
describe("helloWorld", function () {
    //specs -> omschrijvingen van wat de code moet doen
    it("says hello", function () {
        //Matcher -> wat ver wacht ik?
        expect(helloWorld()).toEqual("Hello world");
    });


    it("contains world", function () {
        //Matcher -> wat ver wacht ik?
        expect(helloWorld()).toContain("world");
    });

});