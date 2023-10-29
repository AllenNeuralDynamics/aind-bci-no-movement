//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.9.0.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace BciNoMovementDataSchema.Rig
{
    #pragma warning disable // Disable all warnings

    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class HarpBoard
    {
    
        private HarpBoardDeviceType _deviceType;
    
        private string _portName;
    
        private string _serialNumber;
    
        private string _deviceName;
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="deviceType")]
        public HarpBoardDeviceType DeviceType
        {
            get
            {
                return _deviceType;
            }
            set
            {
                _deviceType = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("portName", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="portName")]
        public string PortName
        {
            get
            {
                return _portName;
            }
            set
            {
                _portName = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="serialNumber")]
        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
            set
            {
                _serialNumber = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("deviceName")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="deviceName")]
        public string DeviceName
        {
            get
            {
                return _deviceName;
            }
            set
            {
                _deviceName = value;
            }
        }
    
        public System.IObservable<HarpBoard> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(
                new HarpBoard
                {
                    DeviceType = _deviceType,
                    PortName = _portName,
                    SerialNumber = _serialNumber,
                    DeviceName = _deviceName
                }));
        }
    }


    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class SpinnakerCamera
    {
    
        private int _binning = 1;
    
        private SpinnakerCameraColorProcessing _colorProcessing = BciNoMovementDataSchema.Rig.SpinnakerCameraColorProcessing.Default;
    
        private int _exposure = 1000;
    
        private int _frameRate = 30;
    
        private double _gain = 0D;
    
        private string _serialNumber;
    
        [Newtonsoft.Json.JsonPropertyAttribute("binning")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="binning")]
        public int Binning
        {
            get
            {
                return _binning;
            }
            set
            {
                _binning = value;
            }
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("colorProcessing")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="colorProcessing")]
        public SpinnakerCameraColorProcessing ColorProcessing
        {
            get
            {
                return _colorProcessing;
            }
            set
            {
                _colorProcessing = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("exposure")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="exposure")]
        public int Exposure
        {
            get
            {
                return _exposure;
            }
            set
            {
                _exposure = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("frameRate")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="frameRate")]
        public int FrameRate
        {
            get
            {
                return _frameRate;
            }
            set
            {
                _frameRate = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("gain")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="gain")]
        public double Gain
        {
            get
            {
                return _gain;
            }
            set
            {
                _gain = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="serialNumber")]
        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
            set
            {
                _serialNumber = value;
            }
        }
    
        public System.IObservable<SpinnakerCamera> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(
                new SpinnakerCamera
                {
                    Binning = _binning,
                    ColorProcessing = _colorProcessing,
                    Exposure = _exposure,
                    FrameRate = _frameRate,
                    Gain = _gain,
                    SerialNumber = _serialNumber
                }));
        }
    }


    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class PwmBuzzer
    {
    
        private string _model = "buzzer";
    
        private string _pin = "DO1";
    
        private double _pwmDefaultPulseDuration = 0.2D;
    
        private double _pwmFrequency = 1000D;
    
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="model")]
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("pin")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="pin")]
        public string Pin
        {
            get
            {
                return _pin;
            }
            set
            {
                _pin = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("pwmDefaultPulseDuration")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="pwmDefaultPulseDuration")]
        public double PwmDefaultPulseDuration
        {
            get
            {
                return _pwmDefaultPulseDuration;
            }
            set
            {
                _pwmDefaultPulseDuration = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("pwmFrequency")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="pwmFrequency")]
        public double PwmFrequency
        {
            get
            {
                return _pwmFrequency;
            }
            set
            {
                _pwmFrequency = value;
            }
        }
    
        public System.IObservable<PwmBuzzer> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(
                new PwmBuzzer
                {
                    Model = _model,
                    Pin = _pin,
                    PwmDefaultPulseDuration = _pwmDefaultPulseDuration,
                    PwmFrequency = _pwmFrequency
                }));
        }
    }


    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class SerialDevice
    {
    
        private string _portName = "COM1";
    
        private string _deviceName;
    
        private int _baudRate = 115200;
    
        [Newtonsoft.Json.JsonPropertyAttribute("portName", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="portName")]
        public string PortName
        {
            get
            {
                return _portName;
            }
            set
            {
                _portName = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("deviceName", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="deviceName")]
        public string DeviceName
        {
            get
            {
                return _deviceName;
            }
            set
            {
                _deviceName = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("baudRate")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="baudRate")]
        public int BaudRate
        {
            get
            {
                return _baudRate;
            }
            set
            {
                _baudRate = value;
            }
        }
    
        public System.IObservable<SerialDevice> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(
                new SerialDevice
                {
                    PortName = _portName,
                    DeviceName = _deviceName,
                    BaudRate = _baudRate
                }));
        }
    }


    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class BciNoMovementRig
    {
    
        private HarpBoard _harpBehaviorBoard = new HarpBoard();
    
        private HarpBoard _harpLoadCellsBoard = new HarpBoard();
    
        private HarpBoard _harpTimestampGeneratorGen3 = new HarpBoard();
    
        private SpinnakerCamera _camera0 = new SpinnakerCamera();
    
        private SpinnakerCamera _camera1 = new SpinnakerCamera();
    
        private PwmBuzzer _speaker = new PwmBuzzer();
    
        private SerialDevice _zaberManipulator = new SerialDevice();
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("harpBehaviorBoard", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="harpBehaviorBoard")]
        public HarpBoard HarpBehaviorBoard
        {
            get
            {
                return _harpBehaviorBoard;
            }
            set
            {
                _harpBehaviorBoard = value;
            }
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("harpLoadCellsBoard", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="harpLoadCellsBoard")]
        public HarpBoard HarpLoadCellsBoard
        {
            get
            {
                return _harpLoadCellsBoard;
            }
            set
            {
                _harpLoadCellsBoard = value;
            }
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("harpTimestampGeneratorGen3", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="harpTimestampGeneratorGen3")]
        public HarpBoard HarpTimestampGeneratorGen3
        {
            get
            {
                return _harpTimestampGeneratorGen3;
            }
            set
            {
                _harpTimestampGeneratorGen3 = value;
            }
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("camera0", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="camera0")]
        public SpinnakerCamera Camera0
        {
            get
            {
                return _camera0;
            }
            set
            {
                _camera0 = value;
            }
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("camera1", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="camera1")]
        public SpinnakerCamera Camera1
        {
            get
            {
                return _camera1;
            }
            set
            {
                _camera1 = value;
            }
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("speaker", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="speaker")]
        public PwmBuzzer Speaker
        {
            get
            {
                return _speaker;
            }
            set
            {
                _speaker = value;
            }
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("zaberManipulator", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="zaberManipulator")]
        public SerialDevice ZaberManipulator
        {
            get
            {
                return _zaberManipulator;
            }
            set
            {
                _zaberManipulator = value;
            }
        }
    
        public System.IObservable<BciNoMovementRig> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(
                new BciNoMovementRig
                {
                    HarpBehaviorBoard = _harpBehaviorBoard,
                    HarpLoadCellsBoard = _harpLoadCellsBoard,
                    HarpTimestampGeneratorGen3 = _harpTimestampGeneratorGen3,
                    Camera0 = _camera0,
                    Camera1 = _camera1,
                    Speaker = _speaker,
                    ZaberManipulator = _zaberManipulator
                }));
        }
    }


    public enum HarpBoardDeviceType
    {
    
        [System.Runtime.Serialization.EnumMemberAttribute(Value="custom")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="custom")]
        Custom = 0,
    
        [System.Runtime.Serialization.EnumMemberAttribute(Value="behavior")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="behavior")]
        Behavior = 1,
    
        [System.Runtime.Serialization.EnumMemberAttribute(Value="clockSynchronizer")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="clockSynchronizer")]
        ClockSynchronizer = 2,
    
        [System.Runtime.Serialization.EnumMemberAttribute(Value="timestampGeneratorGen3")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="timestampGeneratorGen3")]
        TimestampGeneratorGen3 = 3,
    
        [System.Runtime.Serialization.EnumMemberAttribute(Value="loadCells")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="loadCells")]
        LoadCells = 4,
    }


    public enum SpinnakerCameraColorProcessing
    {
    
        [System.Runtime.Serialization.EnumMemberAttribute(Value="Default")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="Default")]
        Default = 0,
    
        [System.Runtime.Serialization.EnumMemberAttribute(Value="NoColorProcessing")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="NoColorProcessing")]
        NoColorProcessing = 1,
    }


    /// <summary>
    /// Serializes a sequence of data model objects into JSON strings.
    /// </summary>
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    [System.ComponentModel.DescriptionAttribute("Serializes a sequence of data model objects into JSON strings.")]
    public partial class SerializeToJson
    {
    
        private System.IObservable<string> Process<T>(System.IObservable<T> source)
        {
            return System.Reactive.Linq.Observable.Select(source, value => Newtonsoft.Json.JsonConvert.SerializeObject(value));
        }

        public System.IObservable<string> Process(System.IObservable<HarpBoard> source)
        {
            return Process<HarpBoard>(source);
        }

        public System.IObservable<string> Process(System.IObservable<SpinnakerCamera> source)
        {
            return Process<SpinnakerCamera>(source);
        }

        public System.IObservable<string> Process(System.IObservable<PwmBuzzer> source)
        {
            return Process<PwmBuzzer>(source);
        }

        public System.IObservable<string> Process(System.IObservable<SerialDevice> source)
        {
            return Process<SerialDevice>(source);
        }

        public System.IObservable<string> Process(System.IObservable<BciNoMovementRig> source)
        {
            return Process<BciNoMovementRig>(source);
        }
    }


    /// <summary>
    /// Deserializes a sequence of JSON strings into data model objects.
    /// </summary>
    [System.ComponentModel.DefaultPropertyAttribute("Type")]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<HarpBoard>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<SpinnakerCamera>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<PwmBuzzer>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<SerialDevice>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<BciNoMovementRig>))]
    [System.ComponentModel.DescriptionAttribute("Deserializes a sequence of JSON strings into data model objects.")]
    public partial class DeserializeFromJson : Bonsai.Expressions.SingleArgumentExpressionBuilder
    {
    
        public DeserializeFromJson()
        {
            Type = new Bonsai.Expressions.TypeMapping<BciNoMovementRig>();
        }

        public Bonsai.Expressions.TypeMapping Type { get; set; }

        public override System.Linq.Expressions.Expression Build(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments)
        {
            var typeMapping = (Bonsai.Expressions.TypeMapping)Type;
            var returnType = typeMapping.GetType().GetGenericArguments()[0];
            return System.Linq.Expressions.Expression.Call(
                typeof(DeserializeFromJson),
                "Process",
                new System.Type[] { returnType },
                System.Linq.Enumerable.Single(arguments));
        }

        private static System.IObservable<T> Process<T>(System.IObservable<string> source)
        {
            return System.Reactive.Linq.Observable.Select(source, value => Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value));
        }
    }


    /// <summary>
    /// Serializes a sequence of data model objects into YAML strings.
    /// </summary>
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    [System.ComponentModel.DescriptionAttribute("Serializes a sequence of data model objects into YAML strings.")]
    public partial class SerializeToYaml
    {
    
        private System.IObservable<string> Process<T>(System.IObservable<T> source)
        {
            return System.Reactive.Linq.Observable.Defer(() =>
            {
                var serializer = new YamlDotNet.Serialization.SerializerBuilder().Build();
                return System.Reactive.Linq.Observable.Select(source, value => serializer.Serialize(value)); 
            });
        }

        public System.IObservable<string> Process(System.IObservable<HarpBoard> source)
        {
            return Process<HarpBoard>(source);
        }

        public System.IObservable<string> Process(System.IObservable<SpinnakerCamera> source)
        {
            return Process<SpinnakerCamera>(source);
        }

        public System.IObservable<string> Process(System.IObservable<PwmBuzzer> source)
        {
            return Process<PwmBuzzer>(source);
        }

        public System.IObservable<string> Process(System.IObservable<SerialDevice> source)
        {
            return Process<SerialDevice>(source);
        }

        public System.IObservable<string> Process(System.IObservable<BciNoMovementRig> source)
        {
            return Process<BciNoMovementRig>(source);
        }
    }


    /// <summary>
    /// Deserializes a sequence of YAML strings into data model objects.
    /// </summary>
    [System.ComponentModel.DefaultPropertyAttribute("Type")]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<HarpBoard>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<SpinnakerCamera>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<PwmBuzzer>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<SerialDevice>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<BciNoMovementRig>))]
    [System.ComponentModel.DescriptionAttribute("Deserializes a sequence of YAML strings into data model objects.")]
    public partial class DeserializeFromYaml : Bonsai.Expressions.SingleArgumentExpressionBuilder
    {
    
        public DeserializeFromYaml()
        {
            Type = new Bonsai.Expressions.TypeMapping<BciNoMovementRig>();
        }

        public Bonsai.Expressions.TypeMapping Type { get; set; }

        public override System.Linq.Expressions.Expression Build(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments)
        {
            var typeMapping = (Bonsai.Expressions.TypeMapping)Type;
            var returnType = typeMapping.GetType().GetGenericArguments()[0];
            return System.Linq.Expressions.Expression.Call(
                typeof(DeserializeFromYaml),
                "Process",
                new System.Type[] { returnType },
                System.Linq.Enumerable.Single(arguments));
        }

        private static System.IObservable<T> Process<T>(System.IObservable<string> source)
        {
            return System.Reactive.Linq.Observable.Defer(() =>
            {
                var serializer = new YamlDotNet.Serialization.DeserializerBuilder().Build();
                return System.Reactive.Linq.Observable.Select(source, value =>
                {
                    var reader = new System.IO.StringReader(value);
                    var parser = new YamlDotNet.Core.MergingParser(new YamlDotNet.Core.Parser(reader));
                    return serializer.Deserialize<T>(parser);
                });
            });
        }
    }
}