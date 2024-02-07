using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Enter_Time_Off_Entry_DataType : INotifyPropertyChanged
	{
		private string time_Off_Entry_IDField;

		private DateTime dateField;

		private decimal requestedField;

		private Time_Off_TypeObjectType time_Off_Type_ReferenceField;

		private Coordinated_Time_Off_TypeObjectType time_Off_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private Time_Off_ReasonObjectType time_Off_Reason_ReferenceField;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Time_Off_Entry_ID
		{
			get
			{
				return this.time_Off_Entry_IDField;
			}
			set
			{
				this.time_Off_Entry_IDField = value;
				this.RaisePropertyChanged("Time_Off_Entry_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
				this.RaisePropertyChanged("Date");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Requested
		{
			get
			{
				return this.requestedField;
			}
			set
			{
				this.requestedField = value;
				this.RaisePropertyChanged("Requested");
			}
		}

		[XmlElement(Order = 3)]
		public Time_Off_TypeObjectType Time_Off_Type_Reference
		{
			get
			{
				return this.time_Off_Type_ReferenceField;
			}
			set
			{
				this.time_Off_Type_ReferenceField = value;
				this.RaisePropertyChanged("Time_Off_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Coordinated_Time_Off_TypeObjectType Time_Off_Reference
		{
			get
			{
				return this.time_Off_ReferenceField;
			}
			set
			{
				this.time_Off_ReferenceField = value;
				this.RaisePropertyChanged("Time_Off_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Time_Off_ReasonObjectType Time_Off_Reason_Reference
		{
			get
			{
				return this.time_Off_Reason_ReferenceField;
			}
			set
			{
				this.time_Off_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Time_Off_Reason_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
