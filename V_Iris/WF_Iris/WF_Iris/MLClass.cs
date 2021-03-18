using System.Collections.Generic;
using System.IO;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;

namespace WF_Iris
{
    public class MLClass
    {
        string modelPath;
        SessionOptions options;
        public MLClass()
        {
            modelPath = Directory.GetCurrentDirectory() + @"\rf_iris.onnx";
            options = new SessionOptions();
            options.GraphOptimizationLevel = GraphOptimizationLevel.ORT_ENABLE_EXTENDED;
        }
        public float[] Predict(float[] inputData)
        {
            List<float> res = new List<float>();
            using (var session = new InferenceSession(modelPath, options))
            {
                var inputMeta = session.InputMetadata;
                var container = new List<NamedOnnxValue>();

                foreach (var name in inputMeta.Keys)
                {
                    var tensor = new DenseTensor<float>(inputData, new[] { 1, 4 });
                    container.Add(NamedOnnxValue.CreateFromTensor<float>(name, tensor));
                }
                
                using (var results = session.Run(container))  // results is an IDisposableReadOnlyCollection<DisposableNamedOnnxValue> container
                {
                    // dump the results
                    foreach (var r in results)
                    {
                        //Debug.WriteLine("Output for {0}", r.Name);
                        if(r.Name == "output_probability")
                        {
                            List<DisposableNamedOnnxValue> v = (List<DisposableNamedOnnxValue>)r.Value;
                            var d = v[0].AsDictionary<string, float>();
                            
                            foreach(var item in d)
                            {
                                res.Add(item.Value);
                            }
                        }
                        //Console.WriteLine(r.AsTensor<string>().GetArrayString());
                    }
                }
            }

            return res.ToArray();
        }
    }
}
