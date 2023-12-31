//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.9.0.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace BciNoMovementDataSchema.TaskLogic
{
    #pragma warning disable // Disable all warnings

    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class Control
    {
    
        private double _baselineThreshold = 0D;
    
        private double _gain = 1D;
    
        private double _lowPassCutOff = -1D;
    
        private double _highPassCutOff = -1D;
    
        /// <summary>
        /// The threshold to be applied to the signal to define baseline
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baselineThreshold")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="baselineThreshold")]
        [System.ComponentModel.DescriptionAttribute("The threshold to be applied to the signal to define baseline")]
        public double BaselineThreshold
        {
            get
            {
                return _baselineThreshold;
            }
            set
            {
                _baselineThreshold = value;
            }
        }
    
        /// <summary>
        /// The gain to be applied to the signal
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gain")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="gain")]
        [System.ComponentModel.DescriptionAttribute("The gain to be applied to the signal")]
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
    
        /// <summary>
        /// Low pass cut off frequency(Hz)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowPassCutOff")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="lowPassCutOff")]
        [System.ComponentModel.DescriptionAttribute("Low pass cut off frequency(Hz)")]
        public double LowPassCutOff
        {
            get
            {
                return _lowPassCutOff;
            }
            set
            {
                _lowPassCutOff = value;
            }
        }
    
        /// <summary>
        /// High pass cut off frequency(Hz)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highPassCutOff")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="highPassCutOff")]
        [System.ComponentModel.DescriptionAttribute("High pass cut off frequency(Hz)")]
        public double HighPassCutOff
        {
            get
            {
                return _highPassCutOff;
            }
            set
            {
                _highPassCutOff = value;
            }
        }
    
        public System.IObservable<Control> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(
                new Control
                {
                    BaselineThreshold = _baselineThreshold,
                    Gain = _gain,
                    LowPassCutOff = _lowPassCutOff,
                    HighPassCutOff = _highPassCutOff
                }));
        }
    }


    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class Point3d
    {
    
        private double _x = 0D;
    
        private double _y = 0D;
    
        private double _z = 0D;
    
        /// <summary>
        /// X coordinate
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="x")]
        [System.ComponentModel.DescriptionAttribute("X coordinate")]
        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
    
        /// <summary>
        /// Y coordinate
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="y")]
        [System.ComponentModel.DescriptionAttribute("Y coordinate")]
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
    
        /// <summary>
        /// Z coordinate
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("z")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="z")]
        [System.ComponentModel.DescriptionAttribute("Z coordinate")]
        public double Z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }
    
        public System.IObservable<Point3d> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(
                new Point3d
                {
                    X = _x,
                    Y = _y,
                    Z = _z
                }));
        }
    }


    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class BciNoMovementTaskLogic
    {
    
        private string _describedBy;
    
        private string _schema_version;
    
        private double _valveOpenTime = 0.01D;
    
        private double _waitMicroscopeTime = 0D;
    
        private double _lickResponseTime = 2D;
    
        private bool _waitForLick = true;
    
        private bool _enableSoundOnRewardZoneEntry = true;
    
        private double _noMovementTimeBeforeTrial = 0D;
    
        private double _interTrialInterval = 0D;
    
        private double _rewardConsumeTime = 2D;
    
        private double _maxTrialDuration = 20D;
    
        private double _farPositionOffset = 8D;
    
        private Point3d _manipulatorResetPosition;
    
        private Control _bciActiveControl;
    
        private Control _bciPassiveControl;
    
        private Control _noMovementPassiveControl;
    
        private bool _skip2pHandshake = false;
    
        private double _punishOnMovementDuration = 0D;
    
        [Newtonsoft.Json.JsonPropertyAttribute("describedBy", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="describedBy")]
        public string DescribedBy
        {
            get
            {
                return _describedBy;
            }
            set
            {
                _describedBy = value;
            }
        }
    
        /// <summary>
        /// schema version
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema_version", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="schema_version")]
        [System.ComponentModel.DescriptionAttribute("schema version")]
        public string Schema_version
        {
            get
            {
                return _schema_version;
            }
            set
            {
                _schema_version = value;
            }
        }
    
        /// <summary>
        /// Time valve remains open (s)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valveOpenTime")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="valveOpenTime")]
        [System.ComponentModel.DescriptionAttribute("Time valve remains open (s)")]
        public double ValveOpenTime
        {
            get
            {
                return _valveOpenTime;
            }
            set
            {
                _valveOpenTime = value;
            }
        }
    
        /// <summary>
        /// Interval (s) after the animal successfully exists the quiescence period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitMicroscopeTime")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="waitMicroscopeTime")]
        [System.ComponentModel.DescriptionAttribute("Interval (s) after the animal successfully exists the quiescence period.")]
        public double WaitMicroscopeTime
        {
            get
            {
                return _waitMicroscopeTime;
            }
            set
            {
                _waitMicroscopeTime = value;
            }
        }
    
        /// <summary>
        /// Interval (s) for the animal to collect reward. Only applies if waitForLick is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lickResponseTime")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="lickResponseTime")]
        [System.ComponentModel.DescriptionAttribute("Interval (s) for the animal to collect reward. Only applies if waitForLick is tru" +
            "e.")]
        public double LickResponseTime
        {
            get
            {
                return _lickResponseTime;
            }
            set
            {
                _lickResponseTime = value;
            }
        }
    
        /// <summary>
        /// Determines whether the animal must lick to trigger reward delivery. If false, reward is immediately delivered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitForLick")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="waitForLick")]
        [System.ComponentModel.DescriptionAttribute("Determines whether the animal must lick to trigger reward delivery. If false, rew" +
            "ard is immediately delivered.")]
        public bool WaitForLick
        {
            get
            {
                return _waitForLick;
            }
            set
            {
                _waitForLick = value;
            }
        }
    
        /// <summary>
        /// Enables audio feedback on reward zone entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSoundOnRewardZoneEntry")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="enableSoundOnRewardZoneEntry")]
        [System.ComponentModel.DescriptionAttribute("Enables audio feedback on reward zone entry.")]
        public bool EnableSoundOnRewardZoneEntry
        {
            get
            {
                return _enableSoundOnRewardZoneEntry;
            }
            set
            {
                _enableSoundOnRewardZoneEntry = value;
            }
        }
    
        /// <summary>
        /// Interval (s) subjects must not move for to start a new trial.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noMovementTimeBeforeTrial")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="noMovementTimeBeforeTrial")]
        [System.ComponentModel.DescriptionAttribute("Interval (s) subjects must not move for to start a new trial.")]
        public double NoMovementTimeBeforeTrial
        {
            get
            {
                return _noMovementTimeBeforeTrial;
            }
            set
            {
                _noMovementTimeBeforeTrial = value;
            }
        }
    
        /// <summary>
        /// Interval (s) between trials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interTrialInterval")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="interTrialInterval")]
        [System.ComponentModel.DescriptionAttribute("Interval (s) between trials.")]
        public double InterTrialInterval
        {
            get
            {
                return _interTrialInterval;
            }
            set
            {
                _interTrialInterval = value;
            }
        }
    
        /// <summary>
        /// Duration (s) for the animal to consume reward.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rewardConsumeTime")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="rewardConsumeTime")]
        [System.ComponentModel.DescriptionAttribute("Duration (s) for the animal to consume reward.")]
        public double RewardConsumeTime
        {
            get
            {
                return _rewardConsumeTime;
            }
            set
            {
                _rewardConsumeTime = value;
            }
        }
    
        /// <summary>
        /// Maximum duration (s) of a trial.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTrialDuration")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="maxTrialDuration")]
        [System.ComponentModel.DescriptionAttribute("Maximum duration (s) of a trial.")]
        public double MaxTrialDuration
        {
            get
            {
                return _maxTrialDuration;
            }
            set
            {
                _maxTrialDuration = value;
            }
        }
    
        /// <summary>
        /// Offset (mm) from the close position to the far position.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("farPositionOffset")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="farPositionOffset")]
        [System.ComponentModel.DescriptionAttribute("Offset (mm) from the close position to the far position.")]
        public double FarPositionOffset
        {
            get
            {
                return _farPositionOffset;
            }
            set
            {
                _farPositionOffset = value;
            }
        }
    
        /// <summary>
        /// Position (mm) to reset the manipulator to.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("manipulatorResetPosition")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="manipulatorResetPosition")]
        [System.ComponentModel.DescriptionAttribute("Position (mm) to reset the manipulator to.")]
        public Point3d ManipulatorResetPosition
        {
            get
            {
                return _manipulatorResetPosition;
            }
            set
            {
                _manipulatorResetPosition = value;
            }
        }
    
        /// <summary>
        /// BCI mode active component control parameters (Displacement = gain * Volt * Seconds)
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("bciActiveControl")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="bciActiveControl")]
        [System.ComponentModel.DescriptionAttribute("BCI mode active component control parameters (Displacement = gain * Volt * Second" +
            "s)")]
        public Control BciActiveControl
        {
            get
            {
                return _bciActiveControl;
            }
            set
            {
                _bciActiveControl = value;
            }
        }
    
        /// <summary>
        /// BCI mode passive component control parameters (Displacement = gain * Seconds)
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("bciPassiveControl")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="bciPassiveControl")]
        [System.ComponentModel.DescriptionAttribute("BCI mode passive component control parameters (Displacement = gain * Seconds)")]
        public Control BciPassiveControl
        {
            get
            {
                return _bciPassiveControl;
            }
            set
            {
                _bciPassiveControl = value;
            }
        }
    
        /// <summary>
        /// No movement mode passive control parameters (Displacement = gain * Seconds)
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("noMovementPassiveControl")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="noMovementPassiveControl")]
        [System.ComponentModel.DescriptionAttribute("No movement mode passive control parameters (Displacement = gain * Seconds)")]
        public Control NoMovementPassiveControl
        {
            get
            {
                return _noMovementPassiveControl;
            }
            set
            {
                _noMovementPassiveControl = value;
            }
        }
    
        /// <summary>
        /// Skip 2p handshake
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skip2pHandshake")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="skip2pHandshake")]
        [System.ComponentModel.DescriptionAttribute("Skip 2p handshake")]
        public bool Skip2pHandshake
        {
            get
            {
                return _skip2pHandshake;
            }
            set
            {
                _skip2pHandshake = value;
            }
        }
    
        /// <summary>
        /// The duration (s) that the spout will stop updating if the animal moves during the trial.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("punishOnMovementDuration")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="punishOnMovementDuration")]
        [System.ComponentModel.DescriptionAttribute("The duration (s) that the spout will stop updating if the animal moves during the" +
            " trial.")]
        public double PunishOnMovementDuration
        {
            get
            {
                return _punishOnMovementDuration;
            }
            set
            {
                _punishOnMovementDuration = value;
            }
        }
    
        public System.IObservable<BciNoMovementTaskLogic> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(
                new BciNoMovementTaskLogic
                {
                    DescribedBy = _describedBy,
                    Schema_version = _schema_version,
                    ValveOpenTime = _valveOpenTime,
                    WaitMicroscopeTime = _waitMicroscopeTime,
                    LickResponseTime = _lickResponseTime,
                    WaitForLick = _waitForLick,
                    EnableSoundOnRewardZoneEntry = _enableSoundOnRewardZoneEntry,
                    NoMovementTimeBeforeTrial = _noMovementTimeBeforeTrial,
                    InterTrialInterval = _interTrialInterval,
                    RewardConsumeTime = _rewardConsumeTime,
                    MaxTrialDuration = _maxTrialDuration,
                    FarPositionOffset = _farPositionOffset,
                    ManipulatorResetPosition = _manipulatorResetPosition,
                    BciActiveControl = _bciActiveControl,
                    BciPassiveControl = _bciPassiveControl,
                    NoMovementPassiveControl = _noMovementPassiveControl,
                    Skip2pHandshake = _skip2pHandshake,
                    PunishOnMovementDuration = _punishOnMovementDuration
                }));
        }
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

        public System.IObservable<string> Process(System.IObservable<Control> source)
        {
            return Process<Control>(source);
        }

        public System.IObservable<string> Process(System.IObservable<Point3d> source)
        {
            return Process<Point3d>(source);
        }

        public System.IObservable<string> Process(System.IObservable<BciNoMovementTaskLogic> source)
        {
            return Process<BciNoMovementTaskLogic>(source);
        }
    }


    /// <summary>
    /// Deserializes a sequence of JSON strings into data model objects.
    /// </summary>
    [System.ComponentModel.DefaultPropertyAttribute("Type")]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<Control>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<Point3d>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<BciNoMovementTaskLogic>))]
    [System.ComponentModel.DescriptionAttribute("Deserializes a sequence of JSON strings into data model objects.")]
    public partial class DeserializeFromJson : Bonsai.Expressions.SingleArgumentExpressionBuilder
    {
    
        public DeserializeFromJson()
        {
            Type = new Bonsai.Expressions.TypeMapping<BciNoMovementTaskLogic>();
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

        public System.IObservable<string> Process(System.IObservable<Control> source)
        {
            return Process<Control>(source);
        }

        public System.IObservable<string> Process(System.IObservable<Point3d> source)
        {
            return Process<Point3d>(source);
        }

        public System.IObservable<string> Process(System.IObservable<BciNoMovementTaskLogic> source)
        {
            return Process<BciNoMovementTaskLogic>(source);
        }
    }


    /// <summary>
    /// Deserializes a sequence of YAML strings into data model objects.
    /// </summary>
    [System.ComponentModel.DefaultPropertyAttribute("Type")]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<Control>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<Point3d>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<BciNoMovementTaskLogic>))]
    [System.ComponentModel.DescriptionAttribute("Deserializes a sequence of YAML strings into data model objects.")]
    public partial class DeserializeFromYaml : Bonsai.Expressions.SingleArgumentExpressionBuilder
    {
    
        public DeserializeFromYaml()
        {
            Type = new Bonsai.Expressions.TypeMapping<BciNoMovementTaskLogic>();
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