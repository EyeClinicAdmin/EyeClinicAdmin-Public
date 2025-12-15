using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

var schema = await JsonSchema.FromFileAsync("../schemas/eca/v1/eyeclinic-dataset.schema.json");
var generator = new CSharpGenerator(schema, new CSharpGeneratorSettings
{
    Namespace = "Namespace",
    ClassStyle = CSharpClassStyle.Record,
    JsonLibrary = CSharpJsonLibrary.SystemTextJson,
    GenerateDataAnnotations = true
});

var code = generator.GenerateFile();
File.WriteAllText("GeneratedClasses.cs", code);