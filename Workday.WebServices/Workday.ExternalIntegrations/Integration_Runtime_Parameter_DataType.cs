using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ExternalIntegrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Runtime_Parameter_DataType : INotifyPropertyChanged
	{
		private string launch_Configurable_NameField;

		private Simple_Work_Data_Runtime_Parameter_NameType[] parameter_NameField;

		private Text_AttributeType[] textField;

		private DateTime dateField;

		private bool dateFieldSpecified;

		private bool booleanField;

		private bool booleanFieldSpecified;

		private InstanceObjectType[] instance_Set_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Launch_Configurable_Name
		{
			get
			{
				return this.launch_Configurable_NameField;
			}
			set
			{
				this.launch_Configurable_NameField = value;
				this.RaisePropertyChanged("Launch_Configurable_Name");
			}
		}

		[XmlElement("Parameter_Name", Order = 1)]
		public Simple_Work_Data_Runtime_Parameter_NameType[] Parameter_Name
		{
			get
			{
				return this.parameter_NameField;
			}
			set
			{
				this.parameter_NameField = value;
				this.RaisePropertyChanged("Parameter_Name");
			}
		}

		[XmlElement("Text", Order = 2)]
		public Text_AttributeType[] Text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
				this.RaisePropertyChanged("Text");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
				this.RaisePropertyChanged("Date");
			}
		}

		[XmlIgnore]
		public bool DateSpecified
		{
			get
			{
				return this.dateFieldSpecified;
			}
			set
			{
				this.dateFieldSpecified = value;
				this.RaisePropertyChanged("DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Boolean
		{
			get
			{
				return this.booleanField;
			}
			set
			{
				this.booleanField = value;
				this.RaisePropertyChanged("Boolean");
			}
		}

		[XmlIgnore]
		public bool BooleanSpecified
		{
			get
			{
				return this.booleanFieldSpecified;
			}
			set
			{
				this.booleanFieldSpecified = value;
				this.RaisePropertyChanged("BooleanSpecified");
			}
		}

		[XmlElement("Instance_Set_Reference", Order = 5)]
		public InstanceObjectType[] Instance_Set_Reference
		{
			get
			{
				return this.instance_Set_ReferenceField;
			}
			set
			{
				this.instance_Set_ReferenceField = value;
				this.RaisePropertyChanged("Instance_Set_Reference");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
