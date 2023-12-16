//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.9.0.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace BciNoMovementDataSchema.Session
{
    #pragma warning disable // Disable all warnings

    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class BciNoMovementSession
    {
    
        private string _describedBy;
    
        private string _schema_version;
    
        private string _experiment;
    
        private string _rootPath;
    
        private string _subject;
    
        private string _version;
    
        private bool _allowDirty = false;
    
        private string _remoteDataPath = "";
    
        private double _rngSeed;
    
        private string _notes;
    
        private string _commitHash;
    
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
        /// Name of the experiment
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experiment", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="experiment")]
        [System.ComponentModel.DescriptionAttribute("Name of the experiment")]
        public string Experiment
        {
            get
            {
                return _experiment;
            }
            set
            {
                _experiment = value;
            }
        }
    
        /// <summary>
        /// Root path of the experiment
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootPath", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="rootPath")]
        [System.ComponentModel.DescriptionAttribute("Root path of the experiment")]
        public string RootPath
        {
            get
            {
                return _rootPath;
            }
            set
            {
                _rootPath = value;
            }
        }
    
        /// <summary>
        /// Name of the subject
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="subject")]
        [System.ComponentModel.DescriptionAttribute("Name of the subject")]
        public string Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
            }
        }
    
        /// <summary>
        /// Version of the experiment
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version", Required=Newtonsoft.Json.Required.Always)]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="version")]
        [System.ComponentModel.DescriptionAttribute("Version of the experiment")]
        public string Version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    
        /// <summary>
        /// Allow code to run from dirty repository
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowDirty")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="allowDirty")]
        [System.ComponentModel.DescriptionAttribute("Allow code to run from dirty repository")]
        public bool AllowDirty
        {
            get
            {
                return _allowDirty;
            }
            set
            {
                _allowDirty = value;
            }
        }
    
        /// <summary>
        /// Path to remote data. If empty, no attempt to copy data will be made
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteDataPath")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="remoteDataPath")]
        [System.ComponentModel.DescriptionAttribute("Path to remote data. If empty, no attempt to copy data will be made")]
        public string RemoteDataPath
        {
            get
            {
                return _remoteDataPath;
            }
            set
            {
                _remoteDataPath = value;
            }
        }
    
        /// <summary>
        /// Seed of the random number generator
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rngSeed")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="rngSeed")]
        [System.ComponentModel.DescriptionAttribute("Seed of the random number generator")]
        public double RngSeed
        {
            get
            {
                return _rngSeed;
            }
            set
            {
                _rngSeed = value;
            }
        }
    
        /// <summary>
        /// Notes about the experiment
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="notes")]
        [System.ComponentModel.DescriptionAttribute("Notes about the experiment")]
        public string Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
            }
        }
    
        /// <summary>
        /// Commit hash of the repository
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitHash")]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="commitHash")]
        [System.ComponentModel.DescriptionAttribute("Commit hash of the repository")]
        public string CommitHash
        {
            get
            {
                return _commitHash;
            }
            set
            {
                _commitHash = value;
            }
        }
    
        public System.IObservable<BciNoMovementSession> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(
                new BciNoMovementSession
                {
                    DescribedBy = _describedBy,
                    Schema_version = _schema_version,
                    Experiment = _experiment,
                    RootPath = _rootPath,
                    Subject = _subject,
                    Version = _version,
                    AllowDirty = _allowDirty,
                    RemoteDataPath = _remoteDataPath,
                    RngSeed = _rngSeed,
                    Notes = _notes,
                    CommitHash = _commitHash
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

        public System.IObservable<string> Process(System.IObservable<BciNoMovementSession> source)
        {
            return Process<BciNoMovementSession>(source);
        }
    }


    /// <summary>
    /// Deserializes a sequence of JSON strings into data model objects.
    /// </summary>
    [System.ComponentModel.DefaultPropertyAttribute("Type")]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<BciNoMovementSession>))]
    [System.ComponentModel.DescriptionAttribute("Deserializes a sequence of JSON strings into data model objects.")]
    public partial class DeserializeFromJson : Bonsai.Expressions.SingleArgumentExpressionBuilder
    {
    
        public DeserializeFromJson()
        {
            Type = new Bonsai.Expressions.TypeMapping<BciNoMovementSession>();
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

        public System.IObservable<string> Process(System.IObservable<BciNoMovementSession> source)
        {
            return Process<BciNoMovementSession>(source);
        }
    }


    /// <summary>
    /// Deserializes a sequence of YAML strings into data model objects.
    /// </summary>
    [System.ComponentModel.DefaultPropertyAttribute("Type")]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<BciNoMovementSession>))]
    [System.ComponentModel.DescriptionAttribute("Deserializes a sequence of YAML strings into data model objects.")]
    public partial class DeserializeFromYaml : Bonsai.Expressions.SingleArgumentExpressionBuilder
    {
    
        public DeserializeFromYaml()
        {
            Type = new Bonsai.Expressions.TypeMapping<BciNoMovementSession>();
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