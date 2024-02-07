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
	public class Merit_Plan_Amount_DataType : INotifyPropertyChanged
	{
		private decimal amountField;

		private bool amountFieldSpecified;

		private Compensation_BasisObjectType compensation_Basis_ReferenceField;

		private bool manage_By_Compensation_Basis_RulesField;

		private bool manage_By_Compensation_Basis_RulesFieldSpecified;

		private Merit_Plan_Profile_Amount_Replacement_DataType[] merit_Plan_Profile_Amount_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Compensation_BasisObjectType Compensation_Basis_Reference
		{
			get
			{
				return this.compensation_Basis_ReferenceField;
			}
			set
			{
				this.compensation_Basis_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Basis_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Manage_By_Compensation_Basis_Rules
		{
			get
			{
				return this.manage_By_Compensation_Basis_RulesField;
			}
			set
			{
				this.manage_By_Compensation_Basis_RulesField = value;
				this.RaisePropertyChanged("Manage_By_Compensation_Basis_Rules");
			}
		}

		[XmlIgnore]
		public bool Manage_By_Compensation_Basis_RulesSpecified
		{
			get
			{
				return this.manage_By_Compensation_Basis_RulesFieldSpecified;
			}
			set
			{
				this.manage_By_Compensation_Basis_RulesFieldSpecified = value;
				this.RaisePropertyChanged("Manage_By_Compensation_Basis_RulesSpecified");
			}
		}

		[XmlElement("Merit_Plan_Profile_Amount_Replacement_Data", Order = 3)]
		public Merit_Plan_Profile_Amount_Replacement_DataType[] Merit_Plan_Profile_Amount_Replacement_Data
		{
			get
			{
				return this.merit_Plan_Profile_Amount_Replacement_DataField;
			}
			set
			{
				this.merit_Plan_Profile_Amount_Replacement_DataField = value;
				this.RaisePropertyChanged("Merit_Plan_Profile_Amount_Replacement_Data");
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
