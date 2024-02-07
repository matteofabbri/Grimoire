using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Benefit_Rounding_Rule_Final_DataType : INotifyPropertyChanged
	{
		private decimal round_Amount_ToField;

		private bool round_Amount_ToFieldSpecified;

		private Benefit_Round_DirectionObjectType rounding_Direction_ReferenceField;

		private decimal round_on_NumberField;

		private bool round_on_NumberFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Round_Amount_To
		{
			get
			{
				return this.round_Amount_ToField;
			}
			set
			{
				this.round_Amount_ToField = value;
				this.RaisePropertyChanged("Round_Amount_To");
			}
		}

		[XmlIgnore]
		public bool Round_Amount_ToSpecified
		{
			get
			{
				return this.round_Amount_ToFieldSpecified;
			}
			set
			{
				this.round_Amount_ToFieldSpecified = value;
				this.RaisePropertyChanged("Round_Amount_ToSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Benefit_Round_DirectionObjectType Rounding_Direction_Reference
		{
			get
			{
				return this.rounding_Direction_ReferenceField;
			}
			set
			{
				this.rounding_Direction_ReferenceField = value;
				this.RaisePropertyChanged("Rounding_Direction_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Round_on_Number
		{
			get
			{
				return this.round_on_NumberField;
			}
			set
			{
				this.round_on_NumberField = value;
				this.RaisePropertyChanged("Round_on_Number");
			}
		}

		[XmlIgnore]
		public bool Round_on_NumberSpecified
		{
			get
			{
				return this.round_on_NumberFieldSpecified;
			}
			set
			{
				this.round_on_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Round_on_NumberSpecified");
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
