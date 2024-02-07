using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Award_Additional_Adjustment_Data__HV_Type : INotifyPropertyChanged
	{
		private decimal itemField;

		private ItemChoiceType4 itemElementNameField;

		private string additional_Adjustment_NotesField;

		private Event_Classification_SubcategoryObjectType additional_Adjustment_Reason_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Additional_Adjustment_Amount", typeof(decimal), Order = 0), XmlElement("Additional_Adjustment_New_Pay_Amount", typeof(decimal), Order = 0), XmlElement("Additional_Adjustment_Percent", typeof(decimal), Order = 0)]
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

		[XmlElement(Order = 1), XmlIgnore]
		public ItemChoiceType4 ItemElementName
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

		[XmlElement(Order = 2)]
		public string Additional_Adjustment_Notes
		{
			get
			{
				return this.additional_Adjustment_NotesField;
			}
			set
			{
				this.additional_Adjustment_NotesField = value;
				this.RaisePropertyChanged("Additional_Adjustment_Notes");
			}
		}

		[XmlElement(Order = 3)]
		public Event_Classification_SubcategoryObjectType Additional_Adjustment_Reason_Reference
		{
			get
			{
				return this.additional_Adjustment_Reason_ReferenceField;
			}
			set
			{
				this.additional_Adjustment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Adjustment_Reason_Reference");
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
