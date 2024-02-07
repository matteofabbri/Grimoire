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
	public class Benchmark_Job_Composite_DataType : INotifyPropertyChanged
	{
		private Compensation_Benchmark_Composite_CategoryObjectType benchmark_Composite_Category_ReferenceField;

		private Compensation_Benchmark_PercentileObjectType competitive_Market_Target_Percentile_ReferenceField;

		private decimal target_Spread__Field;

		private bool target_Spread__FieldSpecified;

		private Compensation_Benchmark_Amount_Replacment_DataType[] benchmark_Amount_Replacement_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Benchmark_Composite_CategoryObjectType Benchmark_Composite_Category_Reference
		{
			get
			{
				return this.benchmark_Composite_Category_ReferenceField;
			}
			set
			{
				this.benchmark_Composite_Category_ReferenceField = value;
				this.RaisePropertyChanged("Benchmark_Composite_Category_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Compensation_Benchmark_PercentileObjectType Competitive_Market_Target_Percentile_Reference
		{
			get
			{
				return this.competitive_Market_Target_Percentile_ReferenceField;
			}
			set
			{
				this.competitive_Market_Target_Percentile_ReferenceField = value;
				this.RaisePropertyChanged("Competitive_Market_Target_Percentile_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Target_Spread__
		{
			get
			{
				return this.target_Spread__Field;
			}
			set
			{
				this.target_Spread__Field = value;
				this.RaisePropertyChanged("Target_Spread__");
			}
		}

		[XmlIgnore]
		public bool Target_Spread__Specified
		{
			get
			{
				return this.target_Spread__FieldSpecified;
			}
			set
			{
				this.target_Spread__FieldSpecified = value;
				this.RaisePropertyChanged("Target_Spread__Specified");
			}
		}

		[XmlElement("Benchmark_Amount_Replacement_Data", Order = 3)]
		public Compensation_Benchmark_Amount_Replacment_DataType[] Benchmark_Amount_Replacement_Data
		{
			get
			{
				return this.benchmark_Amount_Replacement_DataField;
			}
			set
			{
				this.benchmark_Amount_Replacement_DataField = value;
				this.RaisePropertyChanged("Benchmark_Amount_Replacement_Data");
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
