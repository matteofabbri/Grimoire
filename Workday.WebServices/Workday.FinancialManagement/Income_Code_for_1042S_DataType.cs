using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Income_Code_for_1042-S_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Income_Code_for_1042S_DataType : INotifyPropertyChanged
	{
		private string income_CodeField;

		private string descriptionField;

		private Spend_Category_or_HierarchyObjectType[] spend_Categories_or_Hierarchies_ReferenceField;

		private Spend_Category_or_HierarchyObjectType[] federal_Withholding_Spend_Categories_or_Hierarchies_ReferenceField;

		private Spend_Category_or_HierarchyObjectType[] state_Withholding_Spend_Categories_or_Hierarchies_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Income_Code
		{
			get
			{
				return this.income_CodeField;
			}
			set
			{
				this.income_CodeField = value;
				this.RaisePropertyChanged("Income_Code");
			}
		}

		[XmlElement(Order = 1)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement("Spend_Categories_or_Hierarchies_Reference", Order = 2)]
		public Spend_Category_or_HierarchyObjectType[] Spend_Categories_or_Hierarchies_Reference
		{
			get
			{
				return this.spend_Categories_or_Hierarchies_ReferenceField;
			}
			set
			{
				this.spend_Categories_or_Hierarchies_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Categories_or_Hierarchies_Reference");
			}
		}

		[XmlElement("Federal_Withholding_Spend_Categories_or_Hierarchies_Reference", Order = 3)]
		public Spend_Category_or_HierarchyObjectType[] Federal_Withholding_Spend_Categories_or_Hierarchies_Reference
		{
			get
			{
				return this.federal_Withholding_Spend_Categories_or_Hierarchies_ReferenceField;
			}
			set
			{
				this.federal_Withholding_Spend_Categories_or_Hierarchies_ReferenceField = value;
				this.RaisePropertyChanged("Federal_Withholding_Spend_Categories_or_Hierarchies_Reference");
			}
		}

		[XmlElement("State_Withholding_Spend_Categories_or_Hierarchies_Reference", Order = 4)]
		public Spend_Category_or_HierarchyObjectType[] State_Withholding_Spend_Categories_or_Hierarchies_Reference
		{
			get
			{
				return this.state_Withholding_Spend_Categories_or_Hierarchies_ReferenceField;
			}
			set
			{
				this.state_Withholding_Spend_Categories_or_Hierarchies_ReferenceField = value;
				this.RaisePropertyChanged("State_Withholding_Spend_Categories_or_Hierarchies_Reference");
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
