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
	public class Edit_Position_Event_DataType : INotifyPropertyChanged
	{
		private Event_Classification_SubcategoryObjectType position_Change_Reason_ReferenceField;

		private Filled_Position_Edit_Details_DataType filled_Position_Edit_Details_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Event_Classification_SubcategoryObjectType Position_Change_Reason_Reference
		{
			get
			{
				return this.position_Change_Reason_ReferenceField;
			}
			set
			{
				this.position_Change_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Position_Change_Reason_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Filled_Position_Edit_Details_DataType Filled_Position_Edit_Details_Data
		{
			get
			{
				return this.filled_Position_Edit_Details_DataField;
			}
			set
			{
				this.filled_Position_Edit_Details_DataField = value;
				this.RaisePropertyChanged("Filled_Position_Edit_Details_Data");
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
