using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using GoogleMeasurementProtocol.Parameters;
using GoogleMeasurementProtocol.Parameters.Hit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Test_ParameterDefinitions
{
    [TestClass]
    public class ParameterTypeConsistency
    {
        [TestMethod]
        public void Check_all_parameters_for_having_same_type_for_ValueType_property_and_value_param_in_constructor()
        {
            var paramTypesWithInconsistencies = new StringBuilder();

            var googleMeasurementProtocolAssembly = Assembly.GetAssembly(typeof(HitType));

            var valueTypeProperty = typeof(Parameter).GetProperty("ValueType");

            foreach (var paramType in googleMeasurementProtocolAssembly.GetExportedTypes().Where(t=>t.IsSubclassOf(typeof(Parameter)) && t.Name != "ClientId"))
            {
                var constructors = paramType.GetConstructors();

                foreach (var constructor in constructors)
                {
                    var valueParam = constructor.GetParameters().FirstOrDefault(p => p.Name == "value");

                    if (valueParam == null)
                        continue;

                    var instance = (Parameter) FormatterServices.GetUninitializedObject(paramType);
                    instance.Value = "test string";

                    if (((Type)valueTypeProperty.GetValue(instance)) != valueParam.ParameterType)
                    {
                        paramTypesWithInconsistencies.Append($"{paramType.Name}, ");
                    }
                }
            }

            Assert.IsTrue(paramTypesWithInconsistencies.Length == 0, $"Following parameters have inconsistent type specifications: {paramTypesWithInconsistencies.ToString().Trim().TrimEnd(',')}");
        }
    }
}
