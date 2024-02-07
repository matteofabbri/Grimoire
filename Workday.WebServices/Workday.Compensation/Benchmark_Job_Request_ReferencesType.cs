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
	public class Benchmark_Job_Request_ReferencesType : INotifyPropertyChanged
	{
		private Compensation_Benchmark_DefaultObjectType[] benchmark_Job_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Benchmark_Job_Reference", Order = 0)]
		public Compensation_Benchmark_DefaultObjectType[] Benchmark_Job_Reference
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
