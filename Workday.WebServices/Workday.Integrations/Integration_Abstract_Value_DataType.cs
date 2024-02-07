using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Abstract_Value_DataType : INotifyPropertyChanged
	{
		private string textField;

		private DateTime dateField;

		private bool dateFieldSpecified;

		private DateTime dateTimeField;

		private bool dateTimeFieldSpecified;

		private decimal numericField;

		private bool numericFieldSpecified;

		private bool booleanField;

		private bool booleanFieldSpecified;

		private InstanceObjectType[] instance_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Text
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

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(Order = 2)]
		public DateTime DateTime
		{
			get
			{
				return this.dateTimeField;
			}
			set
			{
				this.dateTimeField = value;
				this.RaisePropertyChanged("DateTime");
			}
		}

		[XmlIgnore]
		public bool DateTimeSpecified
		{
			get
			{
				return this.dateTimeFieldSpecified;
			}
			set
			{
				this.dateTimeFieldSpecified = value;
				this.RaisePropertyChanged("DateTimeSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Numeric
		{
			get
			{
				return this.numericField;
			}
			set
			{
				this.numericField = value;
				this.RaisePropertyChanged("Numeric");
			}
		}

		[XmlIgnore]
		public bool NumericSpecified
		{
			get
			{
				return this.numericFieldSpecified;
			}
			set
			{
				this.numericFieldSpecified = value;
				this.RaisePropertyChanged("NumericSpecified");
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

		[XmlElement("Instance_Reference", Order = 5)]
		public InstanceObjectType[] Instance_Reference
		{
			get
			{
				return this.instance_ReferenceField;
			}
			set
			{
				this.instance_ReferenceField = value;
				this.RaisePropertyChanged("Instance_Reference");
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
