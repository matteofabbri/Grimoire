using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Benchmark_JobType : INotifyPropertyChanged
	{
		private Compensation_Benchmark_DefaultObjectType benchmark_Job_ReferenceField;

		private Benchmark_Job_DataType[] benchmark_Job_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Benchmark_DefaultObjectType Benchmark_Job_Reference
		{
			get
			{
				return this.benchmark_Job_ReferenceField;
			}
			set
			{
				this.benchmark_Job_ReferenceField = value;
				this.RaisePropertyChanged("Benchmark_Job_Reference");
			}
		}

		[XmlElement("Benchmark_Job_Data", Order = 1)]
		public Benchmark_Job_DataType[] Benchmark_Job_Data
		{
			get
			{
				return this.benchmark_Job_DataField;
			}
			set
			{
				this.benchmark_Job_DataField = value;
				this.RaisePropertyChanged("Benchmark_Job_Data");
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
