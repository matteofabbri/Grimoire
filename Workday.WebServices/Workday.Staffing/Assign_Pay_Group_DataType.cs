using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_Pay_Group_DataType : INotifyPropertyChanged
	{
		private Pay_GroupObjectType pay_Group_ReferenceField;

		private Position_ElementObjectType[] additional_Positions_for_Pay_Group_Assignment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Pay_GroupObjectType Pay_Group_Reference
		{
			get
			{
				return this.pay_Group_ReferenceField;
			}
			set
			{
				this.pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Group_Reference");
			}
		}

		[XmlElement("Additional_Positions_for_Pay_Group_Assignment_Reference", Order = 1)]
		public Position_ElementObjectType[] Additional_Positions_for_Pay_Group_Assignment_Reference
		{
			get
			{
				return this.additional_Positions_for_Pay_Group_Assignment_ReferenceField;
			}
			set
			{
				this.additional_Positions_for_Pay_Group_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Positions_for_Pay_Group_Assignment_Reference");
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
