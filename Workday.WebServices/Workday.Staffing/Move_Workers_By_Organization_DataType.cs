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
	public class Move_Workers_By_Organization_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private StaffObjectType from_Organization_ReferenceField;

		private Move_Workers_By_Organization_Position_DataType[] move_Workers_By_Organization_Position_DataField;

		private StaffObjectType to_Organization_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(Order = 1)]
		public StaffObjectType From_Organization_Reference
		{
			get
			{
				return this.from_Organization_ReferenceField;
			}
			set
			{
				this.from_Organization_ReferenceField = value;
				this.RaisePropertyChanged("From_Organization_Reference");
			}
		}

		[XmlElement("Move_Workers_By_Organization_Position_Data", Order = 2)]
		public Move_Workers_By_Organization_Position_DataType[] Move_Workers_By_Organization_Position_Data
		{
			get
			{
				return this.move_Workers_By_Organization_Position_DataField;
			}
			set
			{
				this.move_Workers_By_Organization_Position_DataField = value;
				this.RaisePropertyChanged("Move_Workers_By_Organization_Position_Data");
			}
		}

		[XmlElement(Order = 3)]
		public StaffObjectType To_Organization_Reference
		{
			get
			{
				return this.to_Organization_ReferenceField;
			}
			set
			{
				this.to_Organization_ReferenceField = value;
				this.RaisePropertyChanged("To_Organization_Reference");
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
