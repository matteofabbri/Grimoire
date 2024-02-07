using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Period_Activity_Rate_Matrix_Entry_Sequence_DataType : INotifyPropertyChanged
	{
		private decimal default_Unit_RateField;

		private bool default_Unit_RateFieldSpecified;

		private decimal itemField;

		private ItemChoiceType10 itemElementNameField;

		private Unique_IdentifierObjectType accelerator_Base_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Default_Unit_Rate
		{
			get
			{
				return this.default_Unit_RateField;
			}
			set
			{
				this.default_Unit_RateField = value;
				this.RaisePropertyChanged("Default_Unit_Rate");
			}
		}

		[XmlIgnore]
		public bool Default_Unit_RateSpecified
		{
			get
			{
				return this.default_Unit_RateFieldSpecified;
			}
			set
			{
				this.default_Unit_RateFieldSpecified = value;
				this.RaisePropertyChanged("Default_Unit_RateSpecified");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Accelerator_Amount", typeof(decimal), Order = 1), XmlElement("Accelerator_Percent", typeof(decimal), Order = 1)]
		public decimal Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 2), XmlIgnore]
		public ItemChoiceType10 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 3)]
		public Unique_IdentifierObjectType Accelerator_Base_Reference
		{
			get
			{
				return this.accelerator_Base_ReferenceField;
			}
			set
			{
				this.accelerator_Base_ReferenceField = value;
				this.RaisePropertyChanged("Accelerator_Base_Reference");
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
