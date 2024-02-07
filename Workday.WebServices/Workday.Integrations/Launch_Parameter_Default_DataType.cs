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
	public class Launch_Parameter_Default_DataType : INotifyPropertyChanged
	{
		private Parameter_Initialization_OperatorObjectType value_Type_ReferenceField;

		private External_FieldObjectType external_Field_ReferenceField;

		private bool booleanField;

		private bool booleanFieldSpecified;

		private decimal currencyField;

		private bool currencyFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime dateField;

		private bool dateFieldSpecified;

		private DateTime dateTimeField;

		private bool dateTimeFieldSpecified;

		private decimal numericField;

		private bool numericFieldSpecified;

		private string textField;

		private InstanceObjectType[] instance_ReferenceField;

		private Integration_EnumerationObjectType enumeration_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Parameter_Initialization_OperatorObjectType Value_Type_Reference
		{
			get
			{
				return this.value_Type_ReferenceField;
			}
			set
			{
				this.value_Type_ReferenceField = value;
				this.RaisePropertyChanged("Value_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public External_FieldObjectType External_Field_Reference
		{
			get
			{
				return this.external_Field_ReferenceField;
			}
			set
			{
				this.external_Field_ReferenceField = value;
				this.RaisePropertyChanged("External_Field_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public decimal Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
				this.RaisePropertyChanged("Currency");
			}
		}

		[XmlIgnore]
		public bool CurrencySpecified
		{
			get
			{
				return this.currencyFieldSpecified;
			}
			set
			{
				this.currencyFieldSpecified = value;
				this.RaisePropertyChanged("CurrencySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement("Instance_Reference", Order = 9)]
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

		[XmlElement(Order = 10)]
		public Integration_EnumerationObjectType Enumeration_Reference
		{
			get
			{
				return this.enumeration_ReferenceField;
			}
			set
			{
				this.enumeration_ReferenceField = value;
				this.RaisePropertyChanged("Enumeration_Reference");
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
