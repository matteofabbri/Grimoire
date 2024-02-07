using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Previous_System_Compensation_History_DataType : INotifyPropertyChanged
	{
		private Compensation_Previous_System_HistoryObjectType previous_System_Compensation_History_ReferenceField;

		private Previous_System_Compensation_History_Detail_DataType previous_System_Compensation_History_Detail_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Previous_System_HistoryObjectType Previous_System_Compensation_History_Reference
		{
			get
			{
				return this.previous_System_Compensation_History_ReferenceField;
			}
			set
			{
				this.previous_System_Compensation_History_ReferenceField = value;
				this.RaisePropertyChanged("Previous_System_Compensation_History_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Previous_System_Compensation_History_Detail_DataType Previous_System_Compensation_History_Detail_Data
		{
			get
			{
				return this.previous_System_Compensation_History_Detail_DataField;
			}
			set
			{
				this.previous_System_Compensation_History_Detail_DataField = value;
				this.RaisePropertyChanged("Previous_System_Compensation_History_Detail_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
