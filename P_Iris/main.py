import pandas as pd
from pandas.plotting import scatter_matrix
import matplotlib.pyplot as plt
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LogisticRegression
from skl2onnx import convert_sklearn
from skl2onnx.common.data_types import FloatTensorType

data = pd.read_csv('https://archive.ics.uci.edu/ml/machine-learning-databases/iris/iris.data', sep=",",
                   names=['sepal length in cm', 'sepal width in cm', 'petal length in cm', 'petal width in cm',
                          'class'])

description = data.describe()
print(description)
scatter_matrix(data)
figure = plt.gcf()
figure.set_size_inches(10, 10)
plt.savefig("../images/sample.png", dpi=100)

array = data.values
x = array[:, 0:4]
y = array[:, 4]

x_train, x_test, y_train, y_test = train_test_split(x, y, test_size=0.2, random_state=2020)

lr = LogisticRegression(penalty='l2', random_state=2020, solver='liblinear')
lr.fit(x_train, y_train)

score = lr.score(x_test, y_test)

print('score:', score)

initial_type = [('float_input', FloatTensorType([None, 4]))]
onx = convert_sklearn(lr, initial_types=initial_type)
with open("../model/rf_iris.onnx", "wb") as f:
    f.write(onx.SerializeToString())
