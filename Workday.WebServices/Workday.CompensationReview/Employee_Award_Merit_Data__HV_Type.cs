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
	public class Employee_Award_Merit_Data__HV_Type : INotifyPropertyChanged
	{
		private decimal itemField;

		private ItemChoiceType2 itemElementNameField;

		private string merit_Adjustment_CommentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Merit_Amount", typeof(decimal), Order = 0), XmlElement("Merit_Increase_Percent", typeof(decimal), Order = 0), XmlElement("Merit_Increase_Weighted_Percent", typeof(decimal), Order = 0), XmlElement("Merit_New_Pay_Amount", typeof(decimal), Order = 0)]
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
		public ItemChoiceType2 ItemElementName
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
		public string Merit_Adjustment_Comment
		{
			get
			{
				return this.merit_Adjustment_CommentField;
			}
			set
			{
				this.merit_Adjustment_CommentField = value;
				this.RaisePropertyChanged("Merit_Adjustment_Comment");
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
