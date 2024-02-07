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
	public class Employee_Award_Bonus_Data__HV_Type : INotifyPropertyChanged
	{
		private Bonus_PlanObjectType bonus_Plan_ReferenceField;

		private decimal itemField;

		private ItemChoiceType5 itemElementNameField;

		private string bonus_NotesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Bonus_PlanObjectType Bonus_Plan_Reference
		{
			get
			{
				return this.bonus_Plan_ReferenceField;
			}
			set
			{
				this.bonus_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Bonus_Plan_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Bonus_Amount", typeof(decimal), Order = 1), XmlElement("Bonus_Factor_Percent", typeof(decimal), Order = 1), XmlElement("Bonus_Percent", typeof(decimal), Order = 1)]
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
		public ItemChoiceType5 ItemElementName
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
		public string Bonus_Notes
		{
			get
			{
				return this.bonus_NotesField;
			}
			set
			{
				this.bonus_NotesField = value;
				this.RaisePropertyChanged("Bonus_Notes");
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
