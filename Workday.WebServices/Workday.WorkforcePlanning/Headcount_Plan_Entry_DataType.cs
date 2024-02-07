using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Headcount_Plan_Entry_DataType : INotifyPropertyChanged
	{
		private Headcount_Plan_EntryObjectType headcount_Plan_Entry_ReferenceField;

		private Headcount_Plan_Entry_Detail_DataType[] headcount_Plan_Entry_Detail_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Headcount_Plan_EntryObjectType Headcount_Plan_Entry_Reference
		{
			get
			{
				return this.headcount_Plan_Entry_ReferenceField;
			}
			set
			{
				this.headcount_Plan_Entry_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Entry_Reference");
			}
		}

		[XmlElement("Headcount_Plan_Entry_Detail_Data", Order = 1)]
		public Headcount_Plan_Entry_Detail_DataType[] Headcount_Plan_Entry_Detail_Data
		{
			get
			{
				return this.headcount_Plan_Entry_Detail_DataField;
			}
			set
			{
				this.headcount_Plan_Entry_Detail_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Entry_Detail_Data");
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
