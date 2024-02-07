using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Position_Management_Chains_DataType : INotifyPropertyChanged
	{
		private Management_Chain_DataType[] position_Supervisory_Management_Chain_DataField;

		private Management_Chain_DataType[] position_Matrix_Management_Chain_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Management_Chain_Data", IsNullable = false)]
		public Management_Chain_DataType[] Position_Supervisory_Management_Chain_Data
		{
			get
			{
				return this.position_Supervisory_Management_Chain_DataField;
			}
			set
			{
				this.position_Supervisory_Management_Chain_DataField = value;
				this.RaisePropertyChanged("Position_Supervisory_Management_Chain_Data");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Management_Chain_Data", IsNullable = false)]
		public Management_Chain_DataType[] Position_Matrix_Management_Chain_Data
		{
			get
			{
				return this.position_Matrix_Management_Chain_DataField;
			}
			set
			{
				this.position_Matrix_Management_Chain_DataField = value;
				this.RaisePropertyChanged("Position_Matrix_Management_Chain_Data");
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
