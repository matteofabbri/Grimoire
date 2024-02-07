using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Tax_Applicability_Request_CriteriaType : INotifyPropertyChanged
	{
		private string tax_Applicability_CodeField;

		private bool itemField;

		private ItemChoiceType1 itemElementNameField;

		private bool item1Field;

		private Item1ChoiceType item1ElementNameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Tax_Applicability_Code
		{
			get
			{
				return this.tax_Applicability_CodeField;
			}
			set
			{
				this.tax_Applicability_CodeField = value;
				this.RaisePropertyChanged("Tax_Applicability_Code");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Non-Taxable", typeof(bool), Order = 1), XmlElement("Taxable", typeof(bool), Order = 1)]
		public bool Item
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
		public ItemChoiceType1 ItemElementName
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

		[XmlChoiceIdentifier("Item1ElementName"), XmlElement("Non-Recoverable", typeof(bool), Order = 3), XmlElement("Recoverable", typeof(bool), Order = 3)]
		public bool Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement(Order = 4), XmlIgnore]
		public Item1ChoiceType Item1ElementName
		{
			get
			{
				return this.item1ElementNameField;
			}
			set
			{
				this.item1ElementNameField = value;
				this.RaisePropertyChanged("Item1ElementName");
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
