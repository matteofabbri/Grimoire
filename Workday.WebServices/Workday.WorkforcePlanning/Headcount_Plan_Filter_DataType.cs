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
	public class Headcount_Plan_Filter_DataType : INotifyPropertyChanged
	{
		private Worktag_and_Aggregation_TypeObjectType dimension_ReferenceField;

		private Accounting_Worktag_and_Aggregation_DimensionObjectType[] headcount_Plan_Filter_Detail_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worktag_and_Aggregation_TypeObjectType Dimension_Reference
		{
			get
			{
				return this.dimension_ReferenceField;
			}
			set
			{
				this.dimension_ReferenceField = value;
				this.RaisePropertyChanged("Dimension_Reference");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Worktag_Reference", IsNullable = false)]
		public Accounting_Worktag_and_Aggregation_DimensionObjectType[] Headcount_Plan_Filter_Detail_Data
		{
			get
			{
				return this.headcount_Plan_Filter_Detail_DataField;
			}
			set
			{
				this.headcount_Plan_Filter_Detail_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Filter_Detail_Data");
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
